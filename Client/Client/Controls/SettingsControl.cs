using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using ClientDetails = Client.Models.ClientDetails;

namespace Client.Controls
{
    public partial class SettingsControl : UserControl
    {

        
        public int client_id = 0;
        public SettingsControl()
        {
            InitializeComponent();
        }

        public  void SettingsControl_Load(object sender, EventArgs e)
        {
            groupBox1.ForeColor = Color.FromArgb(41, 39, 40);
            groupBox2.ForeColor = Color.FromArgb(41, 39, 40);
            updateBtn.BackColor = Color.FromArgb(41, 39, 40);

           

        }

        public  void updateBtn_Click(object sender, EventArgs e)
        {

            API.SQLDatabase.updateClient(client_id, client.Text, password.Text, lastTextBox.Text, firstTextBox.Text, phoneTextBox.Text, emailTextBox.Text);
        }
       
        public void setClientDetails()
        {
            ClientDetails clientDetails = new ClientDetails();
            clientDetails = API.SQLDatabase.GetClientDetails(client_id);
            password.Text = clientDetails.Password;
            client.Text = clientDetails.Username;
            lastTextBox.Text = clientDetails.LastName;
            firstTextBox.Text = clientDetails.FirstName;
            phoneTextBox.Text = clientDetails.Phone;
            emailTextBox.Text = clientDetails.Email;
        }
    }
}
