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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void Form0_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Hide();
            if (radioButton1.Checked)
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            else if (radioButton2.Checked)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            
            else if (radioButton3.Checked)
            {
                Form3 form3= new Form3();
                form3.Show();
            }
            else if (radioButton4.Checked)
            {
                Form4 form4 = new Form4();
                form4.Show();
            }
            else if (radioButton5.Checked)
            {
                Form5 form5 = new Form5();
                form5.Show();
            }
            {
               
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
