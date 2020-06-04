using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void reservedBtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 297);
            restaurantControl.Visible = false;
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 377);
            restaurantControl.Visible = false;
            

        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            popUp.Location = new Point(0, 217);
            restaurantControl.Visible = true;
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            restaurantControl.setRestaurants();
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
    }
}
