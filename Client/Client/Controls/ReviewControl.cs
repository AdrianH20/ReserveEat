using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using ReviewModel = Client.Models.ReviewModel;
using RestaurantModel = Client.Models.RestaurantModel;
using RestaurantRatings = Client.Models.RestaurantRatings;

namespace Client.Forms
{
    public partial class ReviewControl : UserControl


    {

        public int ID_restaurant = 1;
        public int ID_user = 1;
        public Panel Panel = null;

        int nrofrates = 0;
        int nrofreviews = 0;
       
    
        public ReviewControl()
        {

            InitializeComponent();
        }
        private void ReviewControl_Load(object sender, EventArgs e)
        {
            this.nrreview.Text = Convert.ToString(nrofreviews);
            this.nrofratesLabel.Text = Convert.ToString(nrofrates);

            ///if (API.SQLDatabase.checkForRating(ID_restaurant,ID_user)) ratingsPanel.Enabled = false;
            
        }

       

        
        //AddReview

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Please write the review", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();

            }
            else
            {
                string contentReview = textBox1.Text;
                int author = 1;
                API.SQLDatabase.addReview(contentReview, author, ID_restaurant);
                Panel.Controls.Clear();

                RestaurantModel restaurantModel = API.SQLDatabase.GetRestaurant(ID_restaurant);

                List<ReviewModel> reviews = restaurantModel.reviews;
                int posY = 30;


                int nrReviews = 0;
                foreach (ReviewModel r in reviews)
                {


                    Reviews review = new Reviews();
                    review.setInfo(r.Content, r.Author);
                    review.Location = new Point(review.Location.X, posY);
                    posY += 50;


                    nrReviews++;
                    Panel.Controls.Add(review);
                }

                nrreview.Text = nrReviews.ToString();
            }


        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //excelent
            ratingsPanel.Enabled = false;
            API.SQLDatabase.addRating(ID_restaurant, ID_user, 3);
            RestaurantRatings ratings = API.SQLDatabase.getRatings(ID_restaurant);
            setRatings(ratings);

        }


        private void Chbox2_CheckedChanged(object sender, EventArgs e)
        {
            //very good
            ratingsPanel.Enabled = false;
            API.SQLDatabase.addRating(ID_restaurant, ID_user, 2);
            RestaurantRatings ratings = API.SQLDatabase.getRatings(ID_restaurant);
            setRatings(ratings);

        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            //average
            ratingsPanel.Enabled = false;
            API.SQLDatabase.addRating(ID_restaurant, ID_user, 1);
            RestaurantRatings ratings = API.SQLDatabase.getRatings(ID_restaurant);
            setRatings(ratings);
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //bad
            ratingsPanel.Enabled = false;
            API.SQLDatabase.addRating(ID_restaurant, ID_user, 0);
            RestaurantRatings ratings = API.SQLDatabase.getRatings(ID_restaurant);
            setRatings(ratings);
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Label getReviewsLabel()
        {
            return nrreview;
        }
        public void setRatings(RestaurantRatings restaurantRatings)
        {
            excellentLabel.Text = restaurantRatings.Execellent.ToString();
            VeryGoodLabel.Text = restaurantRatings.VeryGood.ToString();
            AverageLabel.Text = restaurantRatings.Average.ToString();
            BadLabel.Text = restaurantRatings.Bad.ToString();

            excProgressB.Value = restaurantRatings.Execellent;
            verygoodProgressBar.Value = restaurantRatings.VeryGood;
            averageProgressBar.Value = restaurantRatings.Average;
            badProgressBar.Value = restaurantRatings.Bad;

            nrofratesLabel.Text = (restaurantRatings.Execellent + restaurantRatings.VeryGood + restaurantRatings.Average + restaurantRatings.Bad).ToString();

        }

        public Panel getRatingsPanel()
        {
            return ratingsPanel;
        }

        
    }
}
