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
using RestaurantRatings = Client.Models.RestaurantRatings;



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

        private void ExitBt_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            
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


            reviewControl1.ID_restaurant = _Id;
            reviewControl1.ID_user = 1;
            reviewControl1.Panel =reviewsPanel ;

            int posY = 30;

            int nrReviews = 0;
            foreach(ReviewModel  r in  reviews)
            {

                Reviews review = new Reviews();
                review.setInfo(r.Content, r.Author);
                review.Location = new Point(review.Location.X, posY);
                posY += 50;


                nrReviews++;
                reviewsPanel.Controls.Add(review);
            }

            reviewControl1.getReviewsLabel().Text = nrReviews.ToString();

            RestaurantRatings restaurantRatings = API.SQLDatabase.getRatings(_Id);

            reviewControl1.setRatings(restaurantRatings);

            if (API.SQLDatabase.checkForRating(reviewControl1.ID_restaurant, reviewControl1.ID_user)) reviewControl1.getRatingsPanel().Enabled = false;
            Namelabel.Text = _NameRestaurant;
            Desclabel.Text = _Description;
        }

        

       

        
        private void Mapbtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 208);
            //view the map

        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 377);
            //view the menu
        }

        private void ExitBt_Click_1(object sender, EventArgs e)
        {

        }
    }
}
