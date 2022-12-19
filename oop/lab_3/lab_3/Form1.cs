using lab_3;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab_3
{
    public partial class Form1 : Form
    {
        Form2 form = null;
        public int x, y, w, h;
        public bool ok = false;
        public int pictx, picty;
        ShapeContainer fl = new ShapeContainer();


        Bitmap bitmap = new Bitmap(1, 1);
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
                labelErrorNewData.Visible = false;
                nx = Int32.Parse(textBoxNewx.Text);
                if (nx < 0)
                {
                    labelErrorNewData.Visible = true;
                }
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
                if (ny < 0)
                {
                    labelErrorNewData.Visible = true;
                }
            }
            catch (FormatException)
            {
                labelErrorNewData.Visible = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") { return; }
            int nx, ny;
            bool ok = true;
            try
            {
                labelFCant.Visible = false;
                labelErrorNewData.Visible = false;
                nx = Int32.Parse(textBoxNewx.Text);
                ny = Int32.Parse(textBoxNewy.Text);
                if ((ny <= 0) | (nx <= 0))
                {
                    labelErrorNewData.Visible = true;
                    ok = false;
                }

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
                if ((ny + f.h > pictureBox1.ClientSize.Height) | (nx + f.w > pictureBox1.ClientSize.Width))
                {
                    ok = false;
                    labelFCant.Visible = true;
                }
                else
                {


                    f.MoveTo(nx, ny);
                    comboBox1.Text = "";
                    textBoxNewx.Text = "";
                    textBoxNewy.Text = "";
                    groupBox1.Visible = false;
                    labelErrorNewData.Visible = false;
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
                if ((form.x + form.w > pictx) | (form.y + form.h > picty))
                {
                    labelFCant.Visible = true;
                    return;
                }
                labelFCant.Visible = false;

                labelSaveComplete.Visible = true;
                labelSaveError.Visible = false;
                if (form.type == "rectangle")
                {
                    Rectangles rect = new Rectangles(form.x, form.y, form.w, form.h);
                    ShapeContainer.AddFigure(rect);
                    rect.Draw();
                    comboBox1.Items.Add(form.type + Rectangles.count);
                }
                else if (form.type == "square")
                {
                    Square squar = new Square(form.x, form.y, form.w);
                    squar.Draw();
                    ShapeContainer.AddFigure(squar);
                    comboBox1.Items.Add(form.type + Square.count);
                }
                else if (form.type == "ellipse")
                {
                    Ellipse ellips = new Figures.Ellipse(form.x, form.y, form.w, form.h);
                    ellips.Draw();
                    ShapeContainer.AddFigure(ellips);
                    comboBox1.Items.Add(form.type + Ellipse.count);
                }
                else if (form.type == "circle")
                {
                    Circle circl = new Circle(form.x, form.y, form.w);
                    circl.Draw();
                    ShapeContainer.AddFigure(circl);
                    comboBox1.Items.Add(form.type + Circle.count);
                }



            }
            else { labelSaveError.Visible = true; labelSaveComplete.Visible = false; }
        }
    }
}
