using Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestaurantModel = Client.Models.RestaurantModel;

namespace Client.Forms
{
    public partial class RestaurantForm : Form
    {
        private int _Id;
        private string _NameRestaurant;
        private string _Address;
        private string _Description;
        private string _Path;
        private int _Stars;

        List<ReviewModel> reviews = new List<ReviewModel>();
        public RestaurantForm(int id)
        {
            InitializeComponent();
            _Id = id;
           
        }

        private void RestaurantForm_Load(object sender, EventArgs e)
        {

            RestaurantModel restaurantModel = API.SQLDatabase.GetRestaurant(_Id);
            
            _NameRestaurant = restaurantModel.Name;
            _Description = restaurantModel.Description;
            _Address = restaurantModel.Address;
            _Path = restaurantModel.Path;
            _Stars = restaurantModel.Stars;

            reviews = restaurantModel.reviews;

        }
    }
}
