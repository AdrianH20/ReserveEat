using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OwnerDesign
{
    public partial class UserControl2 : UserControl
    {
        List<MapObject> objects = new List<MapObject>();
        UserControl3 uc3;
        public UserControl2(UserControl3 uc)
        {
            InitializeComponent();
            uc3 = uc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (MapObject ob in objects)
            {
                ob.saveCoordinates();
            }
            MessageBox.Show("Succes");
        }

     

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) checkBox1.Checked = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                int chairs = Convert.ToInt32(noChairs.Text);
                MapObject mo = new MapObject();
                if (chairs <= 0) MessageBox.Show("Please give a valid number of chairs");
                else
                {
                    if (checkBox1.Checked) MessageBox.Show("Tables can be created only horizontally for now :)");
                    int x, y;
                    mo.createChairs(chairs);
                    mo.SetMap(0, 0);
                    mo.createTable();
                    objects.Add(mo);
                    this.panel1.Controls.Add(mo);
                    mo.Show();
                }
            }
            catch (FormatException exp) { MessageBox.Show("Please give a valid number of chairs"); }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int x, y;
            MapObject mo = new MapObject();
            mo.SetMap(0, 0);
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                x = 400; y = 75;
            }
            else
            {
                checkBox1.Checked = false;
                x = 75; y = 400;
            }
            mo.createBar(x, y);
            this.panel1.Controls.Add(mo);
            mo.Show();
            objects.Add(mo);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MapObject mo = new MapObject();
            mo.SetMap(0, 0);
            int x, y;
            if (checkBox1.Checked) { x = 100; y = 200; }
            else { x = 200; y = 100; }
            mo.createStage(x, y);
            this.panel1.Controls.Add(mo);
            mo.Show();
            objects.Add(mo);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Left = this.Left - 15;
            if (uc3.Left <= 0) timer1.Stop();
            else uc3.Left = uc3.Left - 15;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
