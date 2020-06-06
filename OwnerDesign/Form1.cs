using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwnerDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UserControl3 uc3 = new UserControl3();
            uc3.Location = new Point(974, 20);
            this.Controls.Add(uc3);
            uc3.Show();

            UserControl2 uc2 = new UserControl2(uc3);
            uc2.Location = new Point(974, 20);
            this.Controls.Add(uc2);
            uc2.Show();

            UserControl1 uc1 = new UserControl1(uc2);
            uc1.Location = new Point(0, 50);
            this.Controls.Add(uc1);
            uc1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
