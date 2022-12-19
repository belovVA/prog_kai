using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Line : Figure
    {
        
        public static int count = 0;
        public Line(float x, float y, float w, float h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            count += 1;
            name = "line";

        }
        public Line()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }
        public new void EditCoord(float x, float y) // изменение начальной точки
        {
            this.x = x;
            this.y = y;
            this.w += x;
            this.h += h;
        }
        public override void Draw() // прорисовка 
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawLine(Init.pen, this.x, this.y, this.w, this.h);
            Init.pictureBox.Image = Init.bitmap;

        }
        public override void MoveTo(int x, int y) // смещенме
        {
            if (!((this.x + x < 0) || (this.y + y < 0) ||
                (this.x + x  > Init.pictureBox.Width) || (this.y + y  > Init.pictureBox.Height)
                || (this.w + x < 0) || (this.h + y < 0) ||
                (this.w + x > Init.pictureBox.Width) || (this.h + y > Init.pictureBox.Height)))
            {
                this.x += x;
                this.y += y;
                this.w += x;
                this.h += y;
                this.DeleteF(this, false);
                this.Draw();
            }
        }
        
    }
}
