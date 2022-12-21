using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square : Rectangles
    {
        public static new int count = 0;
        public Square(int x, int y, int w) : base(x, y, w, w) { count += 1; }
        public Square() { this.x = 0; this.y = 0; this.w = 0; }
        public new void EditCoord(int _x, int _y) // изменение начальной точки
        {
            this.x = _x;
            this.y = _y;
        }
        public override void Draw() // прорисовка 
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, this.x, this.y, this.w, this.w);
            Init.pictureBox.Image = Init.bitmap;

        }
        public override void MoveTo(int x, int y) // смещенме
        {
            if (!((this.x + x < 0) && (this.y + y < 0) || (this.y + y < 0) ||
                (this.x + x > Init.pictureBox.Width && this.y + y < 0) ||
                (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Width) ||
                (this.y + this.w + y > Init.pictureBox.Height) ||
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
            base.Clear();
        }
    }
}
