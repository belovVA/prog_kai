using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Chelovek : Figure
    {
        Circle c1; // head
        Polygon p1; // shorts
        Ellipse e1; // left foot
        Ellipse e2; // left foot
        Ellipse e3; // left hand
        Ellipse e4; // right hand
        Line l1; //body
        Line l2; // left leg
        Line l3; // right leg
        Line l4; // left arm
        Line l5; // right arm
        Line l6;

        public List<Figure> figures;


        public Chelovek(string name, float x, float y, float w, float h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.name = name;
            this.type = "chelovek";
            figures = new List<Figure>();
            c1 = new Circle(x + w / 6 * 3, Convert.ToSingle(y + h / 11 * 1.5), Convert.ToSingle(h / 11 * 1.5));
            l1 = new Line(x + w / 6 * 3, y + h / 11 * 3, x + w / 6 * 3, y + h / 11 * 6);
            this.pts = new Point[] {
                new Point(Convert.ToInt32(x + w / 6 * 4.5), Convert.ToInt32(y + h / 11 * 6)),
                new Point(Convert.ToInt32(x + w / 6 * 4.5),  Convert.ToInt32(y + h / 11 * 9)),
                new Point(Convert.ToInt32(x + w / 6 * 3.5),  Convert.ToInt32(y + h / 11 * 9)),
                new Point(Convert.ToInt32(x + w / 6 * 3),  Convert.ToInt32(y + h / 11 * 8)),
                new Point(Convert.ToInt32(x + w / 6 * 2.5),  Convert.ToInt32(y + h / 11 * 9)),
                new Point(Convert.ToInt32(x + w / 6 * 1.5),  Convert.ToInt32(y + h / 11 * 9)),
                new Point(Convert.ToInt32(x + w / 6 * 1.5),  Convert.ToInt32(y + h / 11 * 6)) };
            p1 = new Polygon(this.pts);
            l2 = new Line(x + w / 6 * 2, y + h / 11 * 9, x + w / 6 * 2, y + h / 11 * 10);
            l3 = new Line(x + w / 6 * 4, y + h / 11 * 9, x + w / 6 * 4, y + h / 11 * 10);
            l4 = new Line(x + w / 6 * 3, Convert.ToSingle(y + h / 11 * 4.5), x + w / 6 * 1, y + h / 11 * 4);
            l5 = new Line(x + w / 6 * 3, Convert.ToSingle(y + h / 11 * 4.5), x + w / 6 * 5, y + h / 11 * 4);
            e1 = new Ellipse(x + w / 6 * 1, y + h / 11 * 10, Convert.ToSingle(w / 6 * 1.5), h / 11);
            e2 = new Ellipse(Convert.ToSingle(x + w / 6 * 3.5), y + h / 11 * 10, Convert.ToSingle(w / 6 * 1.5), h / 11);
            e3 = new Ellipse(x, Convert.ToSingle(y + h / 11 * 3), w / 6 * 1, Convert.ToSingle(h / 11 * 1.5));
            e4 = new Ellipse(Convert.ToSingle(x + w / 6 * 5), Convert.ToSingle(y + h / 11 * 3), w / 6 * 1, Convert.ToSingle(h / 11 * 1.5));
            // l6 = new Line(Convert.ToSingle(x + w / 6 * 1.5),y + h / 11, x + w, y + h / 11 * 2);
            l6 = new Line(Convert.ToSingle(x + w / 6 * 3 - Math.Sqrt(Math.Pow(h / 11 * 1.5, 2) - Math.Pow(h / 11 * 0.5, 2))), y + h / 11, x + w, y + h / 11 * 2);
            Figure[] f_list = { c1, l1, p1, l2, l3, e1, e2, l4, l5, e3, e4, l6 };
            figures.AddRange(f_list);
            name = "chel";
        }
        public override void Draw() // прорисовка 
        {

            foreach (Figure f in figures)
            {
                f.Draw();
            }


        }
        public override void MoveTo(int x_, int y_) // смещенме
        {
            this.x += x_;
            this.y += y_;
            for (int i = 0; i < figures.Count; i++)
            {
                Figure f = figures[i];
                if (f.name != "polygon")
                {
                    f.x += x_;
                    f.y += y_;
                    if (f.name == "line")
                    {
                        f.w += x_;
                        f.h += y_;
                    }
                    
                }
                else
                {
                    for (int q = 0; q < this.pts.Length; q++)
                    {
                        f.pts[q].X += x_;
                        f.pts[q].Y += y_;

                    }

                }

                
                
            }
            this.DeleteF(this, false);
            this.Draw();
            
        }
        
       
    }
}


