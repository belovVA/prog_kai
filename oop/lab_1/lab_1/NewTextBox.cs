using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public class NewTextBox : TextBox

    {
        public int Coord_x { get; set; }
        public int Coord_y { get; set; }
        public NewTextBox(int x,int y)
        {
            this.Coord_x = x;
            this.Coord_y = y;
        }
    }
}
