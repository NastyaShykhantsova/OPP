using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ShapeSpace;

namespace PoligonSpace
{
    public class Poligon:Shape
    {
        public List<Point> points;
        public Poligon(List<Point> ps,Pen pen, Point p1, Point p2)
            : base(pen, p1, p2)
        {
            points = ps;
        }
        public override void Draw(Graphics g)
        {
          
        }
    }
}
