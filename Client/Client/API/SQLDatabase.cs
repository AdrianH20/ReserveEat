using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.IO;
using Client.Models;
using System.Security.Cryptography;


using CardView = Client.Models.CardView;
using RestaurantRatings = Client.Models.RestaurantRatings;
using MenuModel = Client.Models.MenuModel;
using ClientDetails = Client.Models.ClientDetails;

namespace Client.API
{
    class SQLDatabase
    {
       static string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+projectDirectory+ @"\Database.mdf;Integrated Security=True";

        public static List<CardView> GetCardViews()
        {
            List<CardView> cardViews = new List<CardView>();


            string queryString = @"SELECT RestaurantID,Name,Address,PathToLogo FROM Restaurants";
           


            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet dataInfo = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlConnection);
            sqlDataAdapter.Fill(dataInfo, "info");


            foreach(DataRow dr in dataInfo.Tables["info"].Rows)
            {
                CardView cardView = new CardView();
                cardView.ID = int.Parse (dr.ItemArray.GetValue(0).ToString());
                cardView.Name = dr.ItemArray.GetValue(1).ToString();
                cardView.Address = dr.ItemArray.GetValue(2).ToString();
                cardView.Path = projectDirectory + @"\Resources\" + dr.ItemArray.GetValue(3).ToString();
                cardViews.Add(cardView);
            }
            sqlConnection.Close();
            return cardViews;
        }

        public static RestaurantModel GetRestaurant(int id)
        {
            string name="", description="", address="", path="";
            int stars=0;
            List<ReviewModel> reviews = new List<ReviewModel>();
            RestaurantModel restaurantModel = new RestaurantModel();


            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet dataInfo = new DataSet();
            string query1 = @"SELECT Name, Description, Address, PathToLogo, Stars FROM Restaurants WHERE RestaurantID = '"+id+@"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query1, connectionString);
            sqlDataAdapter.Fill(dataInfo, "info");

            foreach(DataRow dr in dataInfo.Tables["info"].Rows)
            {
                name = dr.ItemArray.GetValue(0).ToString();
                description = dr.ItemArray.GetValue(1).ToString();
                address = dr.ItemArray.GetValue(2).ToString();
                path = projectDirectory + @"\Resources\" + dr.ItemArray.GetValue(3).ToString();
                stars = int.Parse(dr.ItemArray.GetValue(4).ToString());
                
            }
            string query2 = @"SELECT Content, UserName FROM Reviews  JOIN Restaurants ON(Reviews.Restaurant = Restaurants.RestaurantID) JOIN Clients ON(Reviews.Author = Clients.ClientId) WHERE Restaurants.RestaurantID ='" + id + @"'";

            DataSet dataInfo2 = new DataSet();
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(query2, connectionString);
            sqlDataAdapter2.Fill(dataInfo2, "info2");

            foreach (DataRow dr in dataInfo2.Tables["info2"].Rows)
            {
                ReviewModel reviewModel = new ReviewModel();
                reviewModel.Content = dr.ItemArray.GetValue(0).ToString();
                reviewModel.Author = dr.ItemArray.GetValue(1).ToString();

                reviews.Add(reviewModel);

            }

            restaurantModel.setInfo(name, address, path, description, stars, reviews);
                sqlConnection.Close();

            

            return restaurantModel;

        }


        public static void addReview(string contentReview,int author,int restaurant)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //INSERT INTO table_name (column1, column2, column3, ...)
            //VALUES(value1, value2, value3, ...);
            string query = @"INSERT INTO Reviews (Content, Author, Restaurant) VALUES('"+contentReview+@"', '" +author.ToString()+@"', '"+restaurant.ToString()+   "')";
           
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static RestaurantRatings getRatings(int id)
        {
            RestaurantRatings restaurantRatings = new RestaurantRatings();

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT Rating from Ratings_Restaurant JOIN Restaurants ON (Ratings_Restaurant.Restaurant = Restaurants.RestaurantID) WHERE Restaurants.RestaurantID = '"+id+"'";
            DataSet dataInfo = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            sqlDataAdapter.Fill(dataInfo, "info");

            int currentRating = 0;

            foreach(DataRow dr in dataInfo.Tables["info"].Rows)
            {
                currentRating = int.Parse(dr.ItemArray.GetValue(0).ToString());

                switch(currentRating)
                {
                    case 0: restaurantRatings.Bad++;break;
                    case 1: restaurantRatings.Average++;break;
                    case 2: restaurantRatings.VeryGood++;break;
                    case 3: restaurantRatings.Execellent++;break;

                }
            }
            connection.Close();
            return   restaurantRatings;
        }

        public static bool checkForRating(int restaurantID, int userID)
        {
            bool isRating = false;

            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
           
            string query = String.Format("SELECT Rating from Ratings_Restaurant JOIN Restaurants ON (Ratings_Restaurant.Restaurant = Restaurants.RestaurantID) JOIN Clients ON (Ratings_Restaurant.Author = Clients.ClientId) WHERE Restaurants.RestaurantID = '{0}' AND Clients.ClientId ='{1}'",restaurantID,userID);
            DataSet dataInfo = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
            sqlDataAdapter.Fill(dataInfo, "info");


            foreach (DataRow dr in dataInfo.Tables["info"].Rows)  isRating = true; 
            connection.Close();
            return isRating;
        }

        public static void addRating(int restaurantID, int userID, int rating)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //INSERT INTO table_name(column1, column2, column3, ...)
            //VALUES(value1, value2, value3, ...);
            string query = String.Format("INSERT INTO Ratings_Restaurant (Restaurant, Author, Rating) VALUES ('{0}', '{1}', '{2}')", restaurantID, userID, rating);
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            connection.Close();

        }

        public static int signIn(string username, string password)
        {
            bool isUser = false;
            int id = 0;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet dataInfo = new DataSet();
            string query = String.Format("SELECT ClientId FROM  Clients WHERE UserName='{0}' AND Password ='{1}'", username, password);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            sqlDataAdapter.Fill(dataInfo, "info");

            foreach (DataRow dataRow in dataInfo.Tables["info"].Rows) { id = int.Parse(dataRow.ItemArray.GetValue(0).ToString()); isUser = true; }


            sqlConnection.Close();

            if (isUser) return id;
            else return 0;

        }

        public static void signUp(string username, string password, string email, string phone)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = String.Format("INSERT into Clients(UserName, Password, Email, Phone) VALUES('{0}', '{1}', '{2}', '{3}')", username, password, email, phone);
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public static List<MenuModel> getMenus(int restaurantID)
        {
            List<MenuModel> menus = new List<MenuModel>();

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = String.Format("SELECT m.MenuID, m.MenuName, m.Description, m.Ingredients, m.Price, m.PathToLogo, m.Restaurant FROM Menus m  JOIN Restaurants r ON m.Restaurant = r.RestaurantID WHERE r.RestaurantID = '{0}'", restaurantID);
            DataSet dataInfo = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

            sqlDataAdapter.Fill(dataInfo, "info");


            foreach (DataRow dataRow in dataInfo.Tables["info"].Rows)
            {
                MenuModel menu = new MenuModel();
                menu.ID = int.Parse(dataRow.ItemArray.GetValue(0).ToString());
                menu.Name = dataRow.ItemArray.GetValue(1).ToString();
                menu.Description = dataRow.ItemArray.GetValue(2).ToString();
                menu.Ingredients = dataRow.ItemArray.GetValue(3).ToString();
                menu.Price = int.Parse(dataRow.ItemArray.GetValue(4).ToString());
                menu.Path = projectDirectory + @"\Resources\" + dataRow.ItemArray.GetValue(5).ToString();

                menu.RestaurantID = int.Parse(dataRow.ItemArray.GetValue(6).ToString());

               
                menus.Add(menu);
            }


            return menus;
        }


        public static ClientDetails GetClientDetails(int userID)
        {
            ClientDetails clientDetails = new ClientDetails();


            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            string query = String.Format("SELECT UserName, Password, LastName, FirstName, Phone, Email FROM Clients WHERE ClientId='{0}'", userID);
            DataSet dataInfo = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

            sqlDataAdapter.Fill(dataInfo, "info");

            foreach (DataRow dataRow in dataInfo.Tables["info"].Rows)
            {
                clientDetails.Username = dataRow.ItemArray.GetValue(0).ToString().Trim();
                clientDetails.Password = dataRow.ItemArray.GetValue(1).ToString().Trim();
                clientDetails.LastName = dataRow.ItemArray.GetValue(2).ToString().Trim();
                clientDetails.FirstName = dataRow.ItemArray.GetValue(3).ToString().Trim();
                clientDetails.Phone = dataRow.ItemArray.GetValue(4).ToString().Trim();
                clientDetails.Email = dataRow.ItemArray.GetValue(5).ToString().Trim();
            }

            return clientDetails;
        }

        public static void updateClient(int userID, string username, string pass, string last, string first, string phone, string email)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string query = String.Format("UPDATE Clients SET UserName='{0}', Password='{1}', LastName='{2}', FirstName='{3}', Phone='{4}', Email='{5}' WHERE ClientId='{6}'", username, pass, last, first, phone, email, userID);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("All the changes have been successfully updated.");
        }

    }
}
