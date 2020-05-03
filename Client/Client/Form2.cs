using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form2 : Form
    {
        String str = " ";
        Graphics g;
        List<Shape> shapes = new List<Shape>();
        public Form2()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        static void WriteToFile(String str)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString().Trim();
            path += "Info.txt";

            try
            {

                // Create a new file     
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(str);

                }

                // Write file contents on console.     
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = panel1.CreateGraphics();

            Pen p = new Pen(Color.Beige);

            foreach (Shape shape in shapes)
            {

                if (shape.Type == "1")
                {
                    SolidBrush sb = new SolidBrush(Color.Bisque);
                    g.DrawEllipse(p, shape.Position.X, shape.Position.Y, 50, 30);
                    g.FillEllipse(sb, shape.Position.X, shape.Position.Y, 50, 30);


                }

                if (shape.Type == "2")
                {
                    SolidBrush sb = new SolidBrush(Color.RosyBrown);
                    g.DrawRectangle(p, shape.Position.X, shape.Position.Y, 100, 40);
                    g.FillRectangle(sb, shape.Position.X, shape.Position.Y, 100, 40);


                }
                if (shape.Type == "3")
                {
                    SolidBrush sb = new SolidBrush(Color.RosyBrown);
                    g.DrawEllipse(p, shape.Position.X, shape.Position.Y, 15, 15);
                    g.FillEllipse(sb, shape.Position.X, shape.Position.Y, 15, 15);


                }
                if (shape.Type == "4")
                {
                    SolidBrush sb = new SolidBrush(Color.RosyBrown);
                    g.DrawEllipse(p, shape.Position.X, shape.Position.Y, 100, 100);
                    g.FillEllipse(sb, shape.Position.X, shape.Position.Y, 100, 100);


                }
                if (shape.Type == "5")
                {
                    SolidBrush sb = new SolidBrush(Color.Bisque);
                    g.DrawEllipse(p, shape.Position.X, shape.Position.Y, 80, 30);
                    g.FillEllipse(sb, shape.Position.X, shape.Position.Y, 80, 30);


                }

            }

        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

            if (listBox1.SelectedItem.ToString() == "Table")
            {
                Shape shape = new Shape("1", Color.Bisque, new Point(e.X, e.Y), 100, 100);
                shapes.Add(shape);
                str = str + "Table " + e.X.ToString() + " " + e.Y.ToString() + " " + shape.Width + " " + shape.Height + " Bisque " + "\n";
            }
            if (listBox1.SelectedItem.ToString() == "Bar")
            {
                Shape shape = new Shape("2", Color.RosyBrown, new Point(e.X, e.Y), 100, 100);
                shapes.Add(shape);
                str = str + "Bar " + e.X.ToString() + " " + e.Y.ToString() + " " + shape.Width + " " + shape.Height + " RosyBrown " + "\n";
            }
            if (listBox1.SelectedItem.ToString() == "Chair")
            {
                Shape shape = new Shape("3", Color.RosyBrown, new Point(e.X, e.Y), 100, 100);
                shapes.Add(shape);
                str = str + "Chair " + e.X.ToString() + " " + e.Y.ToString() + " " + shape.Width + " " + shape.Height + " RosyBrown " + "\n";
            }
            if (listBox1.SelectedItem.ToString() == "Stage")
            {
                Shape shape = new Shape("4", Color.RosyBrown, new Point(e.X, e.Y), 100, 100);
                shapes.Add(shape);
                str = str + "Stage " + e.X.ToString() + " " + e.Y.ToString() + " " + shape.Width + " " + shape.Height + " RosyBrown " + "\n";
            }
            if (listBox1.SelectedItem.ToString() == "Big Table")
            {
                Shape shape = new Shape("5", Color.Bisque, new Point(e.X, e.Y), 100, 100);
                shapes.Add(shape);
                str = str + "Big Table " + e.X.ToString()+" "  + e.Y.ToString() + " " + shape.Width + " " + shape.Height + " Bisque " + "\n";
            }

            WriteToFile(str);
            panel1.Invalidate();

        }

        private static Bitmap DrawControlToBitmap(Control control)
        {
            Bitmap bitmap = new Bitmap(control.Width, control.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Rectangle rectangle = control.RectangleToScreen(control.Bounds);
            graphics.CopyFromScreen(rectangle.Location, Point.Empty, control.Size);
            return bitmap;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = DrawControlToBitmap(panel1);
            string path = AppDomain.CurrentDomain.BaseDirectory.ToString().Trim();
            path += "pozica.jpeg";
            bitmap.Save(path);

            MessageBox.Show("Succes");
        }
    }
}
