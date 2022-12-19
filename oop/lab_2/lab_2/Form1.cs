using lab_2;
using Figures;
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
using System.Diagnostics.Eventing.Reader;

namespace lab_2
{
    public partial class Form1 : Form
    {
        Form2 form = null;
        public int x, y, w, h;
        public bool ok = false;
        static public int pictx, picty;
        ShapeContainer fl = new ShapeContainer();


        Bitmap bitmap = new Bitmap(1,1);
        Pen pen = new Pen(Color.Black, 5);
        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
            Init.pen = this.pen;
            pictx = pictureBox1.ClientSize.Width;
            picty = pictureBox1.ClientSize.Height;


    }

        private void buttonDeleteF_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") { return; }
             
            Figure f = ShapeContainer.figureList[comboBox1.SelectedIndex];
            f.DeleteF(f, true);
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") { return; }
            groupBox1.Visible = true;

            
           
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int nx;
            try
            {
                labelErrorNewData.Visible= false;
                nx = Int32.Parse(textBoxNewx.Text);
                
            }
            catch (FormatException)
            {
                labelErrorNewData.Visible = true;
            }
        }

        private void textBoxNewy_TextChanged(object sender, EventArgs e)
        {
            int ny;
            try
            {
                labelErrorNewData.Visible = false;
                ny = Int32.Parse(textBoxNewy.Text);
            }
            catch (FormatException)
            {
                labelErrorNewData.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelFCant_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
                    }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") { return; }
            int nx, ny;
            bool ok = true;
            try {
                ok = true;
                labelFCant.Visible = false;
                labelErrorNewData.Visible = false;
                nx = Int32.Parse(textBoxNewx.Text);
                ny = Int32.Parse(textBoxNewy.Text);

            }
            catch (FormatException)
            {
                labelErrorNewData.Visible = true;
                ok = false;
            }
            if (ok)
            {
                nx = Int32.Parse(textBoxNewx.Text);
                ny = Int32.Parse(textBoxNewy.Text);
                Figure f = ShapeContainer.figureList[comboBox1.SelectedIndex];
                if ((ny + f.h + f.y > picty) ||
                    (nx + f.w + f.x > pictx) || (ny + f.y <= 0) || (nx + f.x <= 0))
                {

                    ok = false;
                    labelFCant.Visible = true;

                }
                else
                {

                    f.MoveTo(nx, ny);
                    f.x += x;
                    f.y += y;
                   
                    comboBox1.Text = "";
                    textBoxNewx.Text = "";
                    textBoxNewy.Text = "";
                    groupBox1.Visible = false;
                    labelErrorNewData.Visible = false;
                    
                    comboBox1.Items.Clear();
                    foreach (Figure z in ShapeContainer.figureList) {
                        comboBox1.Items.Add(z.name);
                    }
                }
            
               

            
            }
        }


        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
            Init.pictureBox.Image = Init.bitmap;
            comboBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form = new Form2();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Figures.Init.bitmap = bitmap;
            Pen pen = new Pen(Color.Black, 5);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           form.ShowDialog();
           if (form.ok)
            {
                labelSaveComplete.Visible = true;
                labelSaveError.Visible = false;
                if (form.type == "rectangle")
                {
                    Rectangles rect = new Rectangles(form.x,form.y,form.w,form.h);
                    ShapeContainer.AddFigure( rect);
                    rect.Draw();
                    rect.name = form.type + Rectangles.count;
                    comboBox1.Items.Add(rect.name);
                } else if(form.type == "square")
                {
                    Square squar = new Square(form.x, form.y, form.w);
                    squar.Draw();
                    ShapeContainer.AddFigure(squar);
                    squar.name = form.type + Square.count;
                    comboBox1.Items.Add(squar.name);
                }
                else if(form.type == "ellipse")
                {
                    Ellipse ellips = new Figures.Ellipse(form.x, form.y, form.w, form.h);
                    ellips.Draw();
                    ShapeContainer.AddFigure(ellips);
                    ellips.name = form.type + Ellipse.count;
                    comboBox1.Items.Add(ellips.name);
                }
                else if(form.type == "circle")
                {
                    Circle circl = new Circle(form.x, form.y, form.w);
                    circl.Draw();
                    ShapeContainer.AddFigure(circl);
                    circl.name = form.type + Circle.count;
                    comboBox1.Items.Add(circl.name);

                }
                else if(form.type == "polygon")
                {
                    
                    Polygon polygon = new Polygon(form.pts);

                    polygon.Draw();
                    ShapeContainer.AddFigure(polygon);
                    polygon.name = form.type + Polygon.count;
                    comboBox1.Items.Add(polygon.name);
                }
                else if(form.type == "triangle")
                {
                  
                    Triangle triangle = new Triangle(form.pts);
                    triangle.Draw();
                    ShapeContainer.AddFigure(triangle);
                    triangle.name = form.type + Triangle.count;
                    comboBox1.Items.Add(triangle.name);
                }
                else if (form.type == "line")
                {
                    Line line = new Line(form.x, form.y, form.w, form.h);
                    line.Draw();
                    ShapeContainer.AddFigure(line);
                    line.name = form.type + Line.count;
                    comboBox1.Items.Add(line.name);
                }
                else if (form.type == "chelovek")
                {
                   Chelovek chel = new Chelovek(form.name, form.x,form.y,form.w,form.h);
                    chel.Draw();
                    ShapeContainer.AddFigure(chel);
                    chel.name = form.name;
                    comboBox1.Items.Add(chel.name);

                }
                

            }
           else { labelSaveError.Visible = true; labelSaveComplete.Visible = false; }
        }
    }
}
