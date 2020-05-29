using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CardView= Client.Models.CardView;
using RestaurantForm = Client.Forms.RestaurantForm;
 

namespace Client.Controls
{
    public partial class CardViewControl : UserControl
    {

        public int ID { get; set; }
        public PictureBox Logo { get { return this.LogoRestaurant; } }
        public Label RestaurantName { get { return this.Title;} }
        public Label Adresss { get { return this.Address;} }

            
        public CardViewControl()
        {
            InitializeComponent();
        }

        public void  SetCardViewControler(CardView cardView)
        {
           LogoRestaurant.Image = Image.FromFile(cardView.Path);
           LogoRestaurant.SizeMode = PictureBoxSizeMode.StretchImage;

            ID = cardView.ID;
           Title.AutoSize = true;
           Address.AutoSize = true;
           Title.Text = cardView.Name;
           Address.Text = cardView.Address;

        }

        private void CardViewControl_Click(object sender, EventArgs e)
        {
            RestaurantForm restaurantForm= new RestaurantForm(ID);
            restaurantForm.Show();
        }
    }
}
