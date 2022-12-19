using System;
using System.Windows.Forms;

namespace lab_1
{
    public partial class Form5 : Form
    {
        int n;

        const int Mn = 50;
        TextBox[,] Matr = null;// матрица эл-ов типа textbox
        double[,] Matr1 = new double[Mn, Mn]; // матрица вводимых данных
        double[,] Matr2 = new double[Mn, Mn]; // матрица результатов
        double[,] Matr3 = new double[Mn, Mn]; // матрица результатов
        int dx = 30, dy = 20; // ширина и высота ячейки в Matr[,]
        Form6 form6 = null;
        public Form5()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form0 form0 = new Form0();
            form0.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            if (fn())
            {
                n = int.Parse(textBox1.Text);

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Matr[i, j].Visible = true;

                    }

                }
                form6.Width = 10 + n * dx + 20;
                form6.Height = 10 + n * dy + 50 + form6.button1.Height;
                if (form6.ShowDialog() == DialogResult.OK)
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
                                labelErrorMAtr.Visible = true;
                                groupBox1.Visible = false;
                                return;
                            }
                            Matr1[i, j] = Double.Parse(Matr[i, j].Text);
                        }
                    }
                }

                groupBox1.Visible = true;
                labelErrorMAtr.Visible = false;
            }
        }


        bool fn() // проверка правильности ввода порядка матрицы
        {
            try
            {
                n = int.Parse(textBox1.Text);
                if (n <= 0)
                {
                    return false;
                }
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                labelError.Visible = true;
            }
        }

        

        private void Form5_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            form6 = new Form6();
            Matr = new TextBox[Mn, Mn];
            for (int i = 0; i < Mn; i++)
            {
                for (int j = 0; j < Mn; j++)
                {
                    Matr[i, j] = new TextBox();
                    Matr[i, j].Text = "0";
                    Matr[i, j].Location = new System.Drawing.Point(10 + i * dx, 30 + j * dy);
                    Matr[i, j].Size = new System.Drawing.Size(dx, dy);
                    Matr[i, j].Visible = false;
                    form6.Controls.Add(Matr[i, j]);
                }
            }
        }
        private void buttonMatrA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Matr[i, j].Text = Matr1[i, j].ToString();
                }

            form6.ShowDialog();
        }

        private void buttonMatrB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j < i)
                    {
                        Matr2[i, j] = Matr1[i, j];
                    }
                    else
                    {
                        Matr2[i, j] = Matr1[j, i];
                    }
                    Matr[i, j].Text = Matr2[i, j].ToString();
                }
            }

            form6.ShowDialog();
        }

        private void buttonMatrC_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    if (j < i)
                    {
                        Matr3[i, j] = Matr1[i, j];
                    }
                    else
                    {
                        Matr3[i, j] = Matr1[i, j] * (-1);
                    }
                    Matr[i, j].Text = Matr3[i, j].ToString();
                }

            form6.ShowDialog();
        }

        private void Clear_MatrText()
        {
            // Обнуление ячеек Matr
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Matr[i, j].Text = "0";
        }
    }

}
