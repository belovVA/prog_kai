using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Form2 : Form
    {
        public int x, y, w, h;
        public string name, type;
        public bool ok;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox_x_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelError.Visible = false;
                x = Int32.Parse(textBox_x.Text);
                if (x < 0)
                {
                    labelError.Visible = true;
                }
            }
            catch (FormatException)
            {
                labelError.Visible = true;
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Square.Checked) { textBox_h.Enabled = false; }
            else if (radioButton_Circle.Checked) { textBox_h.Enabled = false; }
            else { textBox_h.Enabled = true; }
        }

        private void textBox_y_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelError.Visible = false;
                y = Int32.Parse(textBox_y.Text);
                if (y < 0)
                {
                    labelError.Visible = true;
                }
            }
            catch (FormatException)
            {
                labelError.Visible = true;
            }
        }

        private void textBox_w_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelError.Visible = false;
                w = Int32.Parse(textBox_w.Text);
                if (w < 0)
                {
                    labelError.Visible = true;
                }
            }
            catch (FormatException)
            {
                labelError.Visible = true;
            }
        }

        private void textBox_h_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                labelError.Visible = false;
                h = Int32.Parse(textBox_h.Text);
                if (h < 0)
                {
                    labelError.Visible = true;
                }
            }
            catch (FormatException)
            {
                labelError.Visible = true;
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton_Rect.Checked) {type = "rectangle";}
            else if (radioButton_Square.Checked) { type = "square"; }
            else if (radioButton_Circle.Checked) { type = "circle"; }
            else if (radioButton_Ellipse.Checked) { type = "ellipse"; }
            ok = false;
            try {
                labelError.Visible = false;
                labelFCant.Visible = false;

                x = Int32.Parse(textBox_x.Text);
                y = Int32.Parse(textBox_y.Text);
                w = Int32.Parse(textBox_w.Text);
                if (type == "rectangle" | type == "ellipse")
                {
                    h = Int32.Parse(textBox_h.Text);
                }
                if ((x <= 0) | (y <= 0) | (w <= 0) | (h <= 0))
                {
                    ok = false;
                    labelError.Visible=true;
                }
                else { ok = true; }
               
            }
            catch (FormatException)
            {
                labelError.Visible = true;
                ok = false;
            }
            if (ok)
            {
                clear_all();
                this.Close();

            }

        }
        
        private void clear_all()
        {
            textBox_x.Text = "";
            textBox_y.Text = "";
            textBox_w.Text = "";
            textBox_h.Text = "";

        }
    }
}
