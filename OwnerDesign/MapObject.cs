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
    public partial class MapObject : System.Windows.Forms.UserControl
    {
        public int x { get; set; }
        public int y { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int type { get; set; }
        public Color color { get; set; }
        public int noCh { get; set; }

        Graphics g;
        List<Shape> shapes = new List<Shape>();
        public MapObject()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            this.BringToFront();
            panel1.BringToFront();

        }
        public void SetMap(int x, int y)
        {
            this.Location = new Point(x, y);
            this.BackColor = Color.Transparent;
        }

        public void createTable()
        {
            this.Size = new Size(175, 100);
            panel1.Size = new Size(175, 100);
            Point location = new Point(this.Size.Width / 5, this.Size.Height / 5);
            Shape shape = new Shape("1", Color.FromArgb(252, 161, 125), location, this.Size.Width - (2 * this.Size.Width / 5), this.Size.Height - 2 * this.Size.Height / 5);
            shapes.Add(shape);
            panel1.Invalidate();
        }

        public void createChairs(int noChairs)
        {
            this.Size = new Size(175, 100);
            panel1.Size = new Size(175, 100);
            int noch = noChairs;
            int width = (panel1.Size.Width);
            int height = (panel1.Size.Height);
            int chwidth; int chheight;
            int chairxSus; int chairxJos;
            if (noch >= 6)
            {
                chwidth = panel1.Size.Width / noch;
                chheight = panel1.Size.Height / noch;
            }
            else
            {
                chwidth = panel1.Size.Width / 6;
                chheight = panel1.Size.Height / 6;
            }
            if (noch == 1)
            {
                int chairx = (width - chwidth) / 2;
                Shape shape = new Shape("3", Color.FromArgb(252, 161, 125), new Point(chairx, 0), chwidth, chheight);
                shapes.Add(shape);
            }
            else
            {
                noch = noch - 2;
                Shape shape2 = new Shape("3", Color.FromArgb(252, 161, 125), new Point(0, (height - chheight) / 2), chwidth, chheight);
                Shape shape3 = new Shape("3", Color.FromArgb(252, 161, 125), new Point(width - chwidth, (height - chheight) / 2), chwidth, chheight);
                shapes.Add(shape2);
                shapes.Add(shape3);
                int nochLaturaSus = noch - noch / 2;
                int nochLaturaJos = noch / 2;
                // reprezinta distanta dintre scaune
                chairxSus = (width - nochLaturaSus * chwidth) / (nochLaturaSus + 1);
                chairxJos = (width - nochLaturaJos * chwidth) / (nochLaturaJos + 1);
                int ab = chairxSus;
                for (int i = 1; i <= nochLaturaSus; i++)
                {
                    Shape shape4 = new Shape("3", Color.FromArgb(252, 161, 125), new Point(ab, 0), chwidth, chheight);
                    shapes.Add(shape4);
                    ab += chairxSus + chwidth;
                }
                ab = chairxJos;
                for (int i = 1; i <= nochLaturaJos; i++)
                {
                    Shape shape4 = new Shape("3", Color.FromArgb(252, 161, 125), new Point(ab, height - chheight), chwidth, chheight);
                    shapes.Add(shape4);
                    ab = ab + chairxJos + chwidth;
                }

            }

        }

        public void createBar(int wi, int he)
        {
            this.Size = new Size(wi, he);
            panel1.Size = new Size(wi, he);
            Shape shape = new Shape("2", Color.FromArgb(156, 82, 139), new Point(0, 0), panel1.Size.Width, panel1.Size.Height);
            shapes.Add(shape);
        }

        public void createStage(int wi, int he)
        {
            this.Size = new Size(wi, he);
            panel1.Size = new Size(wi, he);
            Shape shape = new Shape("4", Color.FromArgb(156, 82, 139), new Point(0, 0), panel1.Size.Width, panel1.Size.Height);
            shapes.Add(shape);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.LightGoldenrodYellow);

            foreach (Shape shape in shapes)
            {

                if (String.Equals(shape.Type, "1"))
                {
                    SolidBrush sb = new SolidBrush(shape.Color);
                    p.Color = Color.Bisque;
                    int xTable = shape.Position.X, yTable = shape.Position.Y;
                    int w = Convert.ToInt32(shape.Width); int h = Convert.ToInt32(shape.Height);
                    g.DrawEllipse(p, shape.Position.X, shape.Position.Y, shape.Width, shape.Height);
                    g.FillEllipse(sb, shape.Position.X, shape.Position.Y, shape.Width, shape.Height);
                    type = 1;
                }

                if (shape.Type == "2")
                {
                    SolidBrush sb = new SolidBrush(shape.Color);
                    g.DrawRectangle(p, shape.Position.X, shape.Position.Y, shape.Width, shape.Height);
                    g.FillRectangle(sb, shape.Position.X, shape.Position.Y, shape.Width, shape.Height);
                    type = 2;
                }
                if (shape.Type == "3")
                {
                    SolidBrush sb = new SolidBrush(shape.Color);
                    g.DrawEllipse(p, shape.Position.X, shape.Position.Y, shape.Width, shape.Height);
                    g.FillEllipse(sb, shape.Position.X, shape.Position.Y, shape.Width, shape.Height);

                }
                if (shape.Type == "4")
                {
                    SolidBrush sb = new SolidBrush(shape.Color);
                    g.DrawEllipse(p, shape.Position.X, shape.Position.Y, shape.Width, shape.Height);
                    g.FillEllipse(sb, shape.Position.X, shape.Position.Y, shape.Width, shape.Height);
                    type = 4;
                }
            }
        }
        private Point MouseDownLocation;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                x = e.X + this.Left - MouseDownLocation.X;
                y = e.Y + this.Top - MouseDownLocation.Y;
                this.Location = new Point(x, y);
            }
        }

        public void saveCoordinates()
        {
            x = this.Location.X;
            y = this.Location.Y;
            width = this.Size.Width;
            height = this.Size.Height;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
    }
}

