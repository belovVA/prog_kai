using Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ForLab4;

namespace lab_4
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            IOString.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            IOString.picturebox = pictureBox1;
            IOString.comboBox1 = comboBox1;
            Init.pictureBox = pictureBox1;
            Init.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height); ;
            Init.pen = new Pen(Color.Black);


        }


        private void textBoxInputString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IOString str = new IOString();
                str.ProcessInputString(textBoxInputString.Text);
                
            }
        }

        

       
       
       
       
    }
}
