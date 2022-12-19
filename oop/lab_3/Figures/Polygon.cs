using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public class Polygon:Figure
    {
        int count;
        double[] x = new double[100];
        double[] y = new double[100];
        List<Point> pts = new List<Point>();

        public override void Draw() // прорисовка 
        {
            g.Graphics.DrawPolygon(Pens.Red, pts.ToArray()); //рисуем полигон по точкам из списка points
            Init.pictureBox.Image = Init.bitmap;

        }
        public override void MoveTo(int x, int y) // смещенме
        {
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

