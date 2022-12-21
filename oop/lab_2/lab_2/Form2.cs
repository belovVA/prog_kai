using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_2
{
    public partial class Form2 : Form
    {
        public int x, y, w, h, n;
        public string name, type, size;
        public bool ok = false,k;
        int c = 0;
        public Point[] pts = new Point[10];

        public Form2()
        {
            InitializeComponent();
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ok = false;
            radioButton_Rect.Checked = true;
           
            textBox_x.Text = "";
            textBox_y.Text = "";
            textBox_w.Text = "";
            textBox_h.Text = "";
            textBox_n.Text = "";
            textBox_name.Text = "";

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
            if (radioButton_Polygon.Checked)
            {
                pts = new Point[3];
                clear_all();
                button1.Enabled = false;
                groupBox_date.Visible = false;
                groupBox_poygonDate.Visible = true;
            }
            else if (radioButton_Triangle.Checked) {
                pts = new Point[3];
                button1.Enabled = false;
                clear_all();
                groupBox_date.Visible = false;
                groupBox_poygonDate.Visible = true;
                n = 3;
                textBox_n.Text = "3";
                textBox_n.Enabled = false;
                groupBox2.Visible = true;
            }
            else if (radioButton_Line.Checked)
            {
                clear_all();
                groupBox_date.Visible = true;
                label1.Text = "Коорд. х1";
                label2.Text = "Коорд y1";
                label3.Text = "Коорд х2";
                label4.Text = "Коорд у2";
            }
            else if (radioButton_chel.Checked)
            {
                clear_all();
                
                groupBox_date.Visible = true;
                groupBox_chel.Visible = true;
                name = textBox_name.Text;
            }
            else{
                clear_all();
                groupBox_date.Visible = true;
                 }
            if (radioButton_Square.Checked) { textBox_h.Enabled = false; textBox_h.Text = ""; }
            else if (radioButton_Circle.Checked) { textBox_h.Enabled = false; textBox_h.Text = "";
                label1.Text = "центр X"; label2.Text = "центр Y"; label3.Text = "радиус"; }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x_ = 0; int y_ = 0;

            
            
                k = true;
                try {
                labelFCant.Visible = false;
                    x_ = Int32.Parse(textBox2.Text);
                    y_ = Int32.Parse(textBox3.Text);
                    if (x_ <= 0 || y_ <= 0)  k = false; else k = true;
                if (x_ > Form1.pictx | y_ > Form1.pictx) { k = false; labelFCant.Visible = true; }
                else k = true;
                }
                catch (FormatException) { labelError.Visible = true; k = false; }
                if (k)
                {
                    x_ = Int32.Parse(textBox2.Text);
                    y_ = Int32.Parse(textBox3.Text);



                    Point point = new Point(x_, y_);
                
                pts[c] = point ;
                textBox2.Text = "";
                textBox3.Text = "";
                label8.Visible = true;
                c++;
                }
            if (c == n) { 
                groupBox_poygonDate.Visible = false; 
                textBox1.Text = string.Join(" ", pts.ToArray()) ;
                label9.Visible = true;
                textBox1.Visible = true;
                button1.Enabled = true;
            }
            
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void button_n_Click(object sender, EventArgs e)
        {

            try
            {
                n = Int32.Parse(textBox_n.Text);
                if (n < 3) { labelError.Visible = true; return; }
            }
            catch (FormatException) { labelError.Visible = true; return; }
            n = Int32.Parse(textBox_n.Text);
            textBox_n.Enabled = false;
            groupBox2.Visible = true;
            pts = new Point[n];
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
            if (radioButton_Rect.Checked) { type = "rectangle"; }
            else if (radioButton_Square.Checked) { type = "square"; }
            else if (radioButton_Circle.Checked) { type = "circle"; }
            else if (radioButton_Ellipse.Checked) { type = "ellipse"; }
            else if (radioButton_Line.Checked) { type = "line"; }
            else if (radioButton_chel.Checked) { type = "chelovek"; name = textBox_name.Text; }
            else if (radioButton_Polygon.Checked)
            {
                type = "polygon";
                if (pts.Length > 0) { ok = true; clear_all(); this.Close(); return; }
                else { ok = false; }
            }
            else if (radioButton_Triangle.Checked)
            {
                type = "triangle";
                if (pts.Length > 0) { ok = true; clear_all(); this.Close(); return; }
                else { ok = false; }
            }

                ok = false;
            try {
                labelError.Visible = false;
                labelFCant.Visible = false;

                x = Int32.Parse(textBox_x.Text);
                y = Int32.Parse(textBox_y.Text);
                w = Int32.Parse(textBox_w.Text);
                if (type == "rectangle" | type == "ellipse" | type == "line" | type == "chelovek")
                {
                    h = Int32.Parse(textBox_h.Text);
                }
                if (type == "circle" || type == "square") { h = w; }
                if ((x <= 0) | (y <= 0) | (w <= 0) | (h <= 0))
                {
                    ok = false;
                    labelError.Visible = true;
                }

                else if (((x + w > Form1.pictx) | (y + h > Form1.picty)) && (type != "line"))
                {
                    labelFCant.Visible = true;
                    ok = false;
                }
                else if (((x > Form1.pictx || w > Form1.pictx) || (y > Form1.picty || h > Form1.picty)) && (type == "line"))
                {
                    labelFCant.Visible = true;
                    ok = false;
                    
                }
                else { ok = true; }
                if ((type == "chelovek") && (textBox_name.Text == ""))
                {
                    ok = false;
                }
               
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
            button1.Enabled = true;
            label9.Visible = false;
            textBox1.Visible = false;
            textBox1.Clear();
            textBox_n.Enabled = true; 
            textBox_n.Text = ""; 
            groupBox2.Visible = false;
            n = 0;
            groupBox_poygonDate.Visible = false;
            groupBox_date.Visible = true;
            label8.Visible = false;
            c = 0;
            label1.Text = "Коорд x";
            label2.Text = "Коорд y";
            label3.Text = "Ширина w";
            label4.Text = "Длина h";
            groupBox_chel.Visible = false;


            labelError.Visible = false;
        }
    }
}
