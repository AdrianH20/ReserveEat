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
    public partial class Form1 : Form
    {

        OrderForm orderForm = new OrderForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BackColor = Color.FromArgb(150, 224, 172, 105);
            //FormBorderStyle = FormBorderStyle.None;
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "user" && passwordTextBox.Text == "1234") orderForm.Show();
            /// adaug un comentariu
        }
    }
}
