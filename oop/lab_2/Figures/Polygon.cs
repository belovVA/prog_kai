using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Polygon: Figure
    {
        public static int count = 0;

        
        public Polygon()
        {
            name = "polygon";
        }
        public Polygon(Point[] pts)
        {
            x = 1000;
            y = 1000;
            w = 0;
            h = 0;
            this.pts = pts;
            count++;
            for (int i = 0; i < this.pts.Length; i++)
            {
                x = Math.Min(x, this.pts[i].X);
                y = Math.Min(y, this.pts[i].Y);
                w = Math.Max(x, this.pts[i].X);
                h = Math.Max(y, this.pts[i].Y);
            }
            name = "polygon";
            w -= x;
            h -= y;
        }


        public override void Draw() // прорисовка 
        {
            Graphics g = Graphics.FromImage(Init.bitmap);

            g.DrawPolygon(Init.pen, pts.ToArray()); //рисуем полигон по точкам из списка points
            Init.pictureBox.Image = Init.bitmap;

        }
        public override void MoveTo(int x, int y) // смещенме
        {
            for (int i = 0; i < this.pts.Length; i++)
            {
                this.pts[i].X += x;
                this.pts[i].Y += y;
                
            }
            this.x += x;
            this.y += y;
            this.DeleteF(this, false);
            this.Draw();

        }


    }
}
