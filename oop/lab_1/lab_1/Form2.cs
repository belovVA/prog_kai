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
    public partial class Form2 : Form
    {
        const int n = 12;
        TextBox[,] Matr = null;// матрица эл-ов типа textbox
        double[,] Matr1 = new double[n, n]; // матрица вводимых данных
        double[,] Matr2 = new double[n, n]; // матрица результатов
        int dx = 30, dy = 20; // ширина и высота ячейки в Matr[,]
        public Form2()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form0 form0 = new Form0();
            form0.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {  // добавление эл-ов с матрицы с формы в матрицу1
                for (int j = 0; j < n; j++)
                {
                    labelError.Visible = false;
                    try
                    {
                        Matr1[i, j] = Double.Parse(Matr[i, j].Text);
                    }
                    catch (FormatException)
                    {
                        labelError.Visible = true;
                        return;
                    }
                }
            }
             for (int i = 0; i < n; i++) // получение результативной матрицы
             {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Matr2[i, j] = 0;
                    } else if(i > j)
                    {
                        Matr2[i, j] = 1;
                    }
                    else
                    {
                        Matr2[i, j] = Matr1[i, j];
                    }
                }
             }    
             for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matr[i, j].Text = Matr2[i, j].ToString();
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Matr[i, j].Text = "0";
            labelError.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Matr = new TextBox[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Matr[i, j] = new TextBox();
                    Matr[i, j].Text = "0";
                    Matr[i, j].Location = new System.Drawing.Point(10 + i * dx, 20 + j * dy);
                    Matr[i, j].Size = new System.Drawing.Size(dx, dy);
                    Matr[i, j].Visible = true;
                    groupBox1.Controls.Add(Matr[i, j]);
                }
            }
            
        }
    }
}
