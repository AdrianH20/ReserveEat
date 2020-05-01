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
    public partial class UserForm : Form
    {
        private WaiterForm WaiterForm;
        private int timerIterator = 10;
        private bool changeSlideDirection = false; 

        public UserForm()
        {
            InitializeComponent();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            WaiterForm = new WaiterForm(this);
        }
        private void WaiterForm_Click(object sender, EventArgs e)
        {
            WaiterForm.Show();
            waiterTimer.Start();
        }

        private void waiterTimer_Tick(object sender, EventArgs e)
        {
            WaiterForm.Left += timerIterator;
            if(!changeSlideDirection && WaiterForm.Left>=this.Right-10)
            {
                this.TopMost = false;
                WaiterForm.TopMost = true;
                changeSlideDirection = true;
                timerIterator = -10;
            }
            if(changeSlideDirection && WaiterForm.Left<=this.Left)
            {
                changeSlideDirection = false;
                timerIterator = 10;
                waiterTimer.Stop();
                this.Hide();
            }

        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Clear();
        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
            emailTextBox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.WaiterForm.Close();
            this.Close();

        }
    }
}
