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

namespace Client.API
{
    class SQLDatabase
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Adrian\Desktop\ReserveEat\Client\Client\Database.mdf;Integrated Security=True";

        public static List<CardView> GetCardViews()
        {
            List<CardView> cardViews = new List<CardView>();


            string queryString = @"SELECT RestaurantID,Name,Address,PathToLogo FROM Restaurants";
            var enviroment = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(enviroment).Parent.FullName;


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
    }
}
