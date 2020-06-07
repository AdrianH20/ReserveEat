using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ReservationModel = Client.Models.ReservationModel;

namespace Client.Controls
{
    public partial class ReservationControl : UserControl
    {
        public ReservationControl()
        {
            InitializeComponent();
        }

        private void ReservationControl_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(41, 39, 40);
        }

        public void setInfo (ReservationModel model)
        {
            reservationCode.Text = model.ReservationCode.ToString();
            username.Text = model.Client;
            restaurantName.Text = model.Restaurant;
            date.Text = model.Day;
            startHour.Text = model.StatHour;
            endHour.Text = model.EndHour;
            priceLabel.Text = model.TotalPrice.ToString();

        }
    }
}
