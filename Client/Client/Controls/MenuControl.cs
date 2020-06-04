using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Client.Models;
using Client.Forms;

using Order = Client.Models.Order;
namespace Client.Controls
{
    public partial class MenuControl : UserControl
    {
        public int menu_id = 0;

        public RestaurantForm restaurantForm;
        public MenuControl(RestaurantForm restaurantForm)
        {
            InitializeComponent();
            this.restaurantForm = restaurantForm;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ID = menu_id;
            order.Quantity = (int)quantityNumericUpDown.Value;

            restaurantForm.orders.Add(order);
            
        }

         public void setInfo(MenuModel menuModel)
        {
            title.Text = menuModel.Name;
            descriptionLabel.Text = menuModel.Description;
            ingredientsLabel.Text = menuModel.Ingredients;
            priceLabel.Text = menuModel.Price.ToString() + " lei";
            flowLayoutPanel1.BackColor = Color.FromArgb(41, 39, 40);
            pictureBox1.Image = Image.FromFile(menuModel.Path);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            menu_id = menuModel.ID;
            
        }

        
    }
}
