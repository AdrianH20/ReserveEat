using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class RestaurantForm : Form
    {
        private string _NumeRestaurant;
        public RestaurantForm(int id,string numeRest)
        {
            InitializeComponent();
            _NumeRestaurant = numeRest;
        }

        private void RestaurantForm_Load(object sender, EventArgs e)
        {
            label1.Text = _NumeRestaurant;
        }
    }
}
