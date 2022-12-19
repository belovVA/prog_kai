using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Figures
{
    public class Rectangles : Figure
    {
        public int x;
        public int y;
        public int w;
        public int h;
        public static int count = 0;

        public Rectangles(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            count += 1;

        }
        public Rectangles()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }
        public void EditCoord(int x, int y) // изменение начальной точки
        {
            this.x = x;
            this.y = y;
        }
        public override void Draw() // прорисовка 
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, this.x,this.y, this.w, this.h);
            Init.pictureBox.Image = Init.bitmap;

        }
        public override void MoveTo(int x, int y) // смещенме
        {
            if (!((this.x + x < 0) && (this.y + y < 0) || (this.y + y < 0) ||
                (this.x + x > Init.pictureBox.Width && this.y + y < 0) || 
                (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Width) ||
                (this.y + this.h + y > Init.pictureBox.Height) || 
                (this.x + x < 0 && this.y + y > Init.pictureBox.Height) || (this.x + x < 0)))
            {
                this.x += x;
                this.y += y;
                this.DeleteF(this, false);
                this.Draw();
            }
        }
        public void DeleteF(Figure figure, bool flag = true)
        {
            base.DeleteF(figure, flag);
        }
        public override void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }


    }   
}
