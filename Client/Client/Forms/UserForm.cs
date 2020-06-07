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

            int client_id = API.SQLDatabase.signIn(usernameTextBox.Text, passwordTextBox.Text);

            if (client_id != 0)
            {
                new Home(client_id).Show();
                this.WaiterForm.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to login. Recheck the information");
            }


        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            if (!(usernameTextBox.Text == "Username" || passwordTextBox.Text == "Password" || emailTextBox.Text == "Email (Neccessary only for registration)" || phoneTextBox.Text == "         Phone(Necessary only for registration)"))
            {
                string username = usernameTextBox.Text;
                string pass = passwordTextBox.Text;
                string email = emailTextBox.Text;
                string phone = phoneTextBox.Text;
                API.SQLDatabase.signUp(username, pass, email, phone);

                MessageBox.Show("The account was created");
            }
            else
            {
                MessageBox.Show("Please complete all fields !");
            }
        }
    }
}
