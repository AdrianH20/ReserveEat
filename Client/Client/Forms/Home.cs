using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using ReservedControl = Client.Controls.ReservedControl;
using ClientDetails = Client.Models.ClientDetails;
using ReservationModel = Client.Models.ReservationModel;
using ReservationControl = Client.Controls.ReservationControl;

namespace Client
{
    public partial class Home : Form
    {


        public int client_id;
        public Home(int client_id)
        {
            InitializeComponent();
            this.client_id = client_id;
        }

        private void reservedBtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 297);
            restaurantControl.Visible = false;
            restaurantControl.Enabled = false;
            settingsControl1.Visible = false;
            settingsControl1.Enabled = false;
            

           
            reservedControl.Enabled = true;
            reservedControl.Visible = true;

            reservedControl.Controls.Clear();

            List<ReservationModel> reservations = API.SQLDatabase.getClientReservations(client_id);

            int posY = 20;
            foreach (ReservationModel reservation in reservations)
            {
                ReservationControl reservationControl = new ReservationControl();
                reservationControl.Location = new Point(50, posY);

                reservationControl.setInfo(reservation);

                posY += 160;

                reservedControl.Controls.Add(reservationControl);
            }
            
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 377);
            restaurantControl.Visible = false;
            restaurantControl.Enabled = false;
            reservedControl.Enabled = false;
            reservedControl.Visible = false;

            settingsControl1.Enabled = true;
            settingsControl1.Visible = true;


        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 217);

            reservedControl.Enabled = false;
            reservedControl.Visible = false;
            settingsControl1.Enabled = false;
            settingsControl1.Visible = false;

            restaurantControl.Visible = true;
            restaurantControl.Enabled = true;
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            restaurantControl.client_id = client_id;
            reservedControl.client_id = client_id;
            settingsControl1.client_id = client_id;

            settingsControl1.setClientDetails();
            restaurantControl.setRestaurants();

            reservedControl.Enabled = false;
            reservedControl.Visible = false;
            settingsControl1.Enabled = false;
            settingsControl1.Visible = false;

            restaurantControl.Visible = true;
            restaurantControl.Enabled = true;


        }




        private void reserveBtn_MouseHover(object sender, EventArgs e)
        {
            reserveBtn.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void reservedBtn_MouseHover(object sender, EventArgs e)
        {
            reservedBtn.BackColor = Color.FromArgb(64, 64, 64);
        }
        private void settingsBtn_MouseHover(object sender, EventArgs e)
        {
            this.settingsBtn.BackColor = Color.FromArgb(64, 64, 64);
        }




        private void reserveBtn_MouseLeave(object sender, EventArgs e)
        {
            reserveBtn.BackColor = Color.Transparent;
        }
        private void reservedBtn_MouseLeave(object sender, EventArgs e)
        {
            reservedBtn.BackColor = Color.Transparent;
        }
        private void settingsBtn_MouseLeave(object sender, EventArgs e)
        {
            settingsBtn.BackColor = Color.Transparent;
        }

        private void PopUp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reservedPanel_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("hr");
        }
    }
}
