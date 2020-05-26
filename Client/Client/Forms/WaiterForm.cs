using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class WaiterForm : Form
    {
        private UserForm UserForm;
        private int timerIterator = 10;
        private bool changeSlideDirection = false;
        public WaiterForm(UserForm userForm)
        {
            InitializeComponent();
            UserForm = userForm;
        }
        private void UserForm_Click(object sender, EventArgs e)
        {
            UserForm.Show();
            userTimer.Start();
        }

        private void UserTimer_Tick(object sender, EventArgs e)
        {
            UserForm.Left += timerIterator;
            if (!changeSlideDirection && UserForm.Left >= this.Right - 10)
            {
                this.TopMost = false;
                UserForm.TopMost = true;
                changeSlideDirection = true;
                timerIterator = -10;
            }
            if (changeSlideDirection && UserForm.Left <= this.Left)
            {
                changeSlideDirection = false;
                timerIterator = 10;
                userTimer.Stop();
                this.Hide();
            }
        }

        private void waiterIdTextBox_Click(object sender, EventArgs e)
        {
            waiterIdTextBox.Clear();
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Clear();
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            new Home().Show();
            UserForm.Close();
            this.Close();
        }
    }
}
