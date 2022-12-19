using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public static Pen pen;

        public static bool Check_coord(float x, float y, float w, float h, bool ok)
        {
            if (ok)
            {
                if (!((x < 0) || (x - w <= 0) || (y - h <= 0) || (y < 0) || (x + w >= Init.pictureBox.Width) || (y + h > Init.pictureBox.Height)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (!((x <= 0) || (x - w <= 0) || (y - h <= 0) || (y <= 0) || (x + w >= Init.pictureBox.Width) || (y + h >= Init.pictureBox.Height)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}