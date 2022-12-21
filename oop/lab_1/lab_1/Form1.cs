using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label4.Visible = false;
                double x = double.Parse(textBox1.Text);
                double y = double.Parse(textBox2.Text);
                label7.Visible = true;
                label7.Text = "Точка А(" + x.ToString() + ", " + y.ToString() + ")";
                if ((x <= 1) & (x >= -1) & (y >= -1) & (y <= 1))
                {
                    label7.Text += "\n принадлежит окружности";
                }
                else
                {
                    label7.Text += "\n НЕ принадлежит окружности";
                }
            } catch (FormatException)
            {
                label4.Visible = true;
                label7.Visible = false;
            }
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form0 form0 = new Form0();
            form0.Show();


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
