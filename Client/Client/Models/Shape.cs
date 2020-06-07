﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Client
{

    public class Shape
    {
        public string Type { get; set; }
        public Color Color { get; set; }
        public Point Position { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }

        public Shape(string type, Color color, Point position, float Width, float Height)
        {
            Type = type;
            Color = color;
            Position = position;
            this.Width = Width;
            this.Height = Height;
        }

    }
}
