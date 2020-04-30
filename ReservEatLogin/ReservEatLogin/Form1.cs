using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReservEatLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Form frm2;
        Form frm3;

        private void Form1_Load(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm2.Show();
            frm3 = new Form3();
            frm3.Show();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            frm2.Left += 10;
            if(frm2.Left >= 830)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm2.Show();
            frm2.Left -= 10;
            if (frm2.Left <= 450)
            {
                timer2.Stop();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            frm3.Left += 10;
            if (frm3.Left >= 830)
            {
                timer3.Stop();
                this.TopMost = false;
                frm3.TopMost = true;
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            frm3.Left -= 10;
            if (frm3.Left <= 450)
            {
                timer4.Stop();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }
    }
}
