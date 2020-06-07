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

using MapObject = Client.MapObject;
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

         public  List<MapObject> mapObjects = new List<MapObject>();


        public MapObject selectedTable = null;

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
            mapOuterPanel.Visible = false;

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
            mapOuterPanel.Visible = false;
            //view the map

        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 377);
            //view the menu
            mapOuterPanel.Visible = false;
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
            mapObjects.Clear();
            selectedTable = null;
            popUp.Location = new Point(0, 300);
            menusPanel.Visible = false;
            mapOuterPanel.Visible = true;


            startHourComboBox.SelectedItem = "08:00";
            updateEndHour("08:00");
            button1.BackColor = Color.FromArgb(41, 39, 40);

           mapObjects =  API.SQLDatabase.GetMapObjects(_Id, dateTimePicker1.Value, startHourComboBox.SelectedItem.ToString(), endHourComboBox.SelectedItem.ToString());
            updateMap(mapObjects); 

        }


        public void updateMap(List<MapObject> mapObjects)
        {
            mapPanel.Controls.Clear();
            foreach(MapObject mapObject in mapObjects)
            {
                if(mapObject.type == 1)
                {
                    if (mapObject.availability == false) mapObject.Color = Color.FromArgb(150, 150, 150);
                    mapObject.createChairs(mapObject.noCh);
                    mapObject.SetMap(mapObject.x, mapObject.y);
                    mapObject.createTable();

                    mapObject.RestaurantForm = this;
                    mapPanel.Controls.Add(mapObject);
                    mapObject.Show();
                }
                if (mapObject.type == 4)
                {
                    mapObject.RestaurantForm = this;
                    mapObject.Color = Color.FromArgb(156, 82, 139);
                    mapObject.SetMap(mapObject.x, mapObject.y);
                    mapObject.createStage(mapObject.width,mapObject.height);


                    mapPanel.Controls.Add(mapObject);
                    mapObject.Show();
                }
                if(mapObject.type == 2)
                {
                    mapObject.RestaurantForm = this;
                    mapObject.Color = Color.FromArgb(156, 82, 139);
                    mapObject.SetMap(mapObject.x, mapObject.y);
                    mapObject.createBar( mapObject.width, mapObject.height);

                    mapPanel.Controls.Add(mapObject);
                    mapObject.Show();

                }
            }

        }
        public void updateEndHour(string hour)
        {
            endHourComboBox.Items.Clear();
            DateTime dateTime = DateTime.Parse(hour);
            int integerHour = int.Parse(dateTime.Hour.ToString());

            for (int i = integerHour + 1; i <= 20; i++)
            {
                endHourComboBox.Items.Add(i + ":00");
            }

            endHourComboBox.SelectedIndex = 0;



        }
        private void reviewControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            mapObjects.Clear();
            mapObjects = API.SQLDatabase.GetMapObjects(_Id, dateTimePicker1.Value, startHourComboBox.SelectedItem.ToString(), endHourComboBox.SelectedItem.ToString());
            updateMap(mapObjects);
        }

        private void startHourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapObjects.Clear();

            updateEndHour(startHourComboBox.SelectedItem.ToString());
            mapObjects = API.SQLDatabase.GetMapObjects(_Id, dateTimePicker1.Value, startHourComboBox.SelectedItem.ToString(), endHourComboBox.SelectedItem.ToString());
            updateMap(mapObjects);
        }

        private void endHourComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapObjects.Clear();
            mapObjects = API.SQLDatabase.GetMapObjects(_Id, dateTimePicker1.Value, startHourComboBox.SelectedItem.ToString(), endHourComboBox.SelectedItem.ToString());
            updateMap(mapObjects);
        }

        public int getOrdersTotalPrice(List<Order> orders)
        {
            int totalPrice = 0;
            foreach (Order order in orders)
                totalPrice += order.Quantity * order.Price;


            return totalPrice;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (selectedTable != null)
            {

                int reservationCode = API.SQLDatabase.getNewReservationCode();
                int MapObjectID = selectedTable.id;
                int restaurantID = _Id;
                int clientID = client_id;
                int totalPrice = getOrdersTotalPrice(orders);
                API.SQLDatabase.makeReservation(restaurantID, clientID, dateTimePicker1.Value, DateTime.Parse(startHourComboBox.SelectedItem.ToString()), DateTime.Parse(endHourComboBox.SelectedItem.ToString()), MapObjectID, reservationCode, totalPrice);
                updateMap(mapObjects);

            }
            else MessageBox.Show("Please select a table!");


        }
    }
}
