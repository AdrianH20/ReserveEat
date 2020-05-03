using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomepageFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(0, 297);
            userControl11.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(64, 64, 64);
        }

        

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

       

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            button3.BackColor = Color.Transparent;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(0, 377);
            userControl11.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(0, 217);
            userControl11.Visible = true;
        }
    }
}
