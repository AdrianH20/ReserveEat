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
namespace Client.Forms
{
    public partial class ReviewControl : UserControl


    {

        public int ID_restaurant = 1;
        public Panel Panel = null;

        int nrofrates = 0;
        int nrofreviews = 0;
        int nr_excellent = 0;
        int nr_good = 0;
        int nr_bad = 0;
        int nr_average = 0;
    
        public ReviewControl()
        {
            InitializeComponent();
        }
        private void ReviewControl_Load(object sender, EventArgs e)
        {
            this.nrreview.Text = Convert.ToString(nrofreviews);
            this.nrofrt.Text = Convert.ToString(nrofrates);
            
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
                int posY = 50;


                int nrReviews = 0;
                foreach (ReviewModel r in reviews)
                {


                    Reviews review = new Reviews();
                    review.setInfo(r.Content, r.Author);
                    review.Location = new Point(review.Location.X, posY);
                    posY += 70;


                    nrReviews++;
                    Panel.Controls.Add(review);
                }

                nrreview.Text = nrReviews.ToString();
            }


        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //excelent
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
                progressBar1.Value += 1;
            nr_excellent += 1;
            nrofrates += 1;

        }


        private void Chbox2_CheckedChanged(object sender, EventArgs e)
        {
            //very good
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
                progressBar2.Value += 1;
            nrofrates += 1;
            nr_good += 1;

        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            //average
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
                progressBar3.Value += 1;
            nrofrates += 1;
            nr_average += 1;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //bad
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
                progressBar4.Value += 1;
            nrofrates += 1;
            nr_bad += 1;
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
    }
}
