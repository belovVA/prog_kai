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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form0 form0 = new Form0();
            form0.Show();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label6.Visible = false;
                label7.Visible = false;
                double s = Convert.ToDouble(textBox1.Text);
                if (s <= 0)
                {
                    label7.Visible = true;
                }
                
            }
            catch(FormatException)
            {
                label6.Visible = true;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label10.Visible = false;
                label6.Visible = false;
                double r = Convert.ToDouble(textBox2.Text);
                if (r <= 0)
                {
                    label10.Visible = true;
                }
            }
            catch (FormatException)
            {
                label6.Visible = true;
                label10.Visible = false;
            }

        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                label6.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                double t = Convert.ToDouble(textBox3.Text);
                if (t <= 0)
                {
                    label11.Visible = true;
                }
                if (t % 1 != 0)
                {
                    label12.Visible = true;
                }
            }
            catch (FormatException)
            {
                label6.Visible = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

         private bool Valid_Data()
        {
            try
            {
                label6.Visible = false;
                double s = Convert.ToDouble(textBox1.Text);
                double r = Convert.ToDouble(textBox2.Text);
                double t = Convert.ToDouble(textBox3.Text);
                if ((s <= 0) | (r <= 0) | (t <= 0) | (t % 1 != 0)){
                    return false;
                }
                return true;
                
            }
            catch(FormatException)
            {
                label6.Visible = true;
            }
            return false;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textsum.Text = "";
            dohod.Text = "";
            if (Valid_Data()){
                double s = Convert.ToDouble(textBox1.Text);
                double r = Convert.ToDouble(textBox2.Text);
                double t = Convert.ToDouble(textBox3.Text);
                double sum = s;

                for (int i = 0; i < (int)t; i++)
                {
                    sum += sum * r * 0.01;
                }
                textsum.Text = sum.ToString();
                double d = sum - s;
                dohod.Text = d.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
