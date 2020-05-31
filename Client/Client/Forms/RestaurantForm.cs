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

            int posY = 50;

            int nrReviews = 0;
            foreach(ReviewModel  r in  reviews)
            {

                Reviews review = new Reviews();
                review.setInfo(r.Content, r.Author);
                review.Location = new Point(review.Location.X, posY);
                posY += 70;


                nrReviews++;
                reviewsPanel.Controls.Add(review);
            }

            reviewControl1.getReviewsLabel().Text = nrReviews.ToString();

            RestaurantRatings restaurantRatings = API.SQLDatabase.getRatings(_Id);

            reviewControl1.setRatings(restaurantRatings);

            if (API.SQLDatabase.checkForRating(reviewControl1.ID_restaurant, reviewControl1.ID_user)) reviewControl1.getRatingsPanel().Enabled = false;
            

        }

        
        private void ReviewsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ReviewControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
