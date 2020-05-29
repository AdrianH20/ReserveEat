using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

using CardView = Client.Models.CardView;
using System.Reflection;
using System.IO;
using Client.Models;
using System.Security.Cryptography;

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
    }
}
