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

using MenuControl = Client.Controls.MenuControl;
using Order = Client.Models.Order;
using GMap.NET.MapProviders;

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

        public int  client_id;

        List<MenuModel> menusModels = new  List<MenuModel>();

        List<ReviewModel> reviews = new List<ReviewModel>();

        public List<Order> orders = new List<Order>();
        public RestaurantForm(int id, int client_id)
        {
            InitializeComponent();
            _Id = id;
            this.client_id = client_id;

           
        }

        private void ExitBt_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
            
        }


        private void RestaurantForm_Load(object sender, EventArgs e)
        {

            RestaurantModel restaurantModel = API.SQLDatabase.GetRestaurant(_Id);

            menusPanel.Visible = false;

            _NameRestaurant = restaurantModel.Name;
            _Description = restaurantModel.Description;
            _Address = restaurantModel.Address;
            _Path = restaurantModel.Path;
            _Stars = restaurantModel.Stars;
            reviews = restaurantModel.reviews;

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.ShowCenter = false;
            gMapControl1.SetPositionByKeywords("Cluj-Napoca,Romania");
            

            reviewControl1.ID_restaurant = _Id;
            reviewControl1.ID_user = client_id;
            reviewControl1.Panel =reviewsPanel ;




            reviewsPanel.HorizontalScroll.Maximum = 0;
            reviewsPanel.AutoScroll = false;
            reviewsPanel.VerticalScroll.Visible = false;
            reviewsPanel.HorizontalScroll.Visible = false;
            reviewsPanel.AutoScroll = true;

            int posY = 0;

            int nrReviews = 0;
            foreach(ReviewModel  r in  reviews)
            {

                Reviews review = new Reviews();
                review.setInfo(r.Content, r.Author);
                review.Location = new Point(review.Location.X, posY);
                posY += 100;


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
            popUp.Location = new Point(0, 224);
            menusPanel.Visible = false;
            //view the map

        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 377);
            //view the menu
            menusPanel.Visible = true;


            menusModels = API.SQLDatabase.getMenus(_Id);


            int posY = 0;

            foreach(MenuModel m in menusModels)
            {
                MenuControl menuControl = new MenuControl(this);
                menuControl.setInfo(m);
                menuControl.Location = new Point(menuControl.Location.X, posY);
                posY += 150;

                menusPanel.Controls.Add(menuControl);

            }
        }

        private void ExitBt_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reviewsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 300);
        }

        private void reviewControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
