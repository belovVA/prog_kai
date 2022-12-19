using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Polygon
    {

        public Triangle()
        {
            pts = new Point[10];
        }
        public Triangle(Point[] pts) : base(pts) { }

        
    }
}
