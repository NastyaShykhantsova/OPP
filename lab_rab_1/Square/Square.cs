﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ShapeSpace;

namespace SquareSpace
{
    public class Square:Shape
    {
        public int height;
        public Square(Pen pen, Point p1, Point p2)
            : base(pen, p1, p2)
        {
        }
        public override void Draw(Graphics g)
        {

        }
    }
}
