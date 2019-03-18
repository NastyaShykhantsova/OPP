using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SquareSpace;

namespace RectangleSpace
{
    public class Rectangle:Square
    {
        public int weight;
        public Rectangle(Pen pen, Point p1, Point p2)
            : base(pen, p1, p2)
        {
        }
        public override void Draw(Graphics g)
        {

        }
    }
}
