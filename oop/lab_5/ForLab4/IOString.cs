using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Figures;
namespace ForLab4
{
    public class IOString
    {
        public static Bitmap bitmap;
        public static ComboBox cmbbx_plug;
        public static ComboBox comboBox1;
        public static PictureBox picturebox;

        static Stack<Operator> operators = new Stack<Operator>();
        static Stack<Operand> operands = new Stack<Operand>();
        static ShapeContainer figure_list = new ShapeContainer();
        


        public static void ProcessInputString(string stroke)
        {

            operators.Clear();
            operands.Clear();
            stroke = stroke.Replace(" ", "");
            for (int i = 0; i < stroke.Length; i++)
            {

                char c = stroke[i];
                if (IsNotOperation(c)) // является ли символ названием команды
                {

                    if (!Char.IsDigit(c))
                    {
                        operands.Push(new Operand(c));
                        while (i < stroke.Length - 1 && IsNotOperation(stroke[i + 1])) // считывание строки, пока
                        {                                                               // не встретим операнд
                            string temp_str = operands.Pop().value.ToString() + stroke[i + 1].ToString();
                            operands.Push(new Operand(temp_str));
                            i++;
                        }
                    }
                    else if (Char.IsDigit(c))
                    {
                        operands.Push(new Operand(c));
                        while (i < stroke.Length - 1 && Char.IsDigit(stroke[i + 1]) // считывание числовых значений
                            && IsNotOperation(stroke[i + 1]))
                        {                                                               // пока не встретим операнд
                            int temp_num = Convert.ToInt32(operands.Pop().value.ToString()) * 10 +
                                (int)Char.GetNumericValue(stroke[i + 1]);
                            operands.Push(new Operand(temp_num));
                            i++;
                        }
                        try
                        {
                            if (stroke[i + 1] == '-')
                            {
                                int num = Convert.ToInt32('-' + operands.Pop().value.ToString());
                                operands.Push(new Operand(num));
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            operands.Push(new Operand(c));
                        }
                    }
                }
                else if (c == 'C' || c == 'M' || c == 'D' || c == 'N')
                {
                    if (operators.Count == 0)
                    {
                        operators.Push(OperatorContainer.FindOperator(c));
                    }
                }
                else if (c == '(')
                {
                    operators.Push(OperatorContainer.FindOperator(c));
                }
                else if (c == ')')
                {
                    do // ищем левую скобку и удаляем ее
                    {
                        if (operators.Peek().symbolOperator == '(')
                        {
                            operators.Pop();
                            break;
                        }
                        if (operators.Count == 0)
                        {
                            break;
                        }
                    }
                    while (operators.Peek().symbolOperator != '(');
                }
            }
            ValidateInputString();
            

            
        }
        static void ValidateInputString()
        {
            if (operators.Count > 0) // проверка на пустую строку
            {
                if (IsNotOperation(operators.Peek().symbolOperator)) // если мы не встретили команду
                {
                    MessageBox.Show("Введенной операции не существует.");
                    comboBox1.Items.Add("Введенной операции не существует.");
                }
                else
                {
                    if (ParameterCheck())
                    {
                        SelectingPerformingOperation(operators.Pop());
                    }
                    else
                    {

                        MessageBox.Show($"Команда введена некорректно.");
                        comboBox1.Items.Add("Команда введена некорректно.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели операцию.");
                comboBox1.Items.Add("Вы не ввели операцию.");
            }
        }
        static bool IsNotOperation(char item)
        {
            if (!(item == 'D' || item == 'M' || item == 'N' || item == 'C' || item == ',' || item == '(' || item == ')'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ParameterCheck()
        {
            Stack<Operand> stack = new Stack<Operand>(operands);
            int stack_lenght = stack.Count;
            for (int i = 0; i < stack_lenght; i++)
            {
                Operand operand = stack.Pop();
                if (i == 0)
                {

                }
                else
                {
                    string s = operand.value.ToString();
                    try
                    {
                        int x = Convert.ToInt32(s);
                    }
                    catch (FormatException)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void SelectingPerformingOperation(Operator op)
        {
            if (op.symbolOperator == 'C')
            {
                if (operands.Count == 4)
                {
                    int r = Convert.ToInt32(operands.Pop().value.ToString());
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Circle f in ShapeContainer.figureList)
                    {
                        if (f.name == name)
                        {
                            MessageBox.Show("Фигура с таким именем уже существует.");
                            comboBox1.Items.Add("Фигура с таким именем уже существует.");
                            return;
                        }
                    }
                    Figure figure = new Circle(x, y, r, name);

                    if (Init.Check_coord(x, y, r, r, true))
                    {
                        op = new Operator(figure.Draw, 'C');
                        ShapeContainer.AddFigure(figure);
                        comboBox1.Items.Add($" Фигура {figure.name} создана");
                        op.operatorMethod();
                    }
                    else
                    {
                        MessageBox.Show("Фигура вышла за границы.");
                        comboBox1.Items.Add("Фигура вышла за границы.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор C принимает 4 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора S.");
                }

            }
            else if (op.symbolOperator == 'M')
            {
                if (operands.Count == 3)
                {
                    Circle figure = null;
                    int y = Convert.ToInt32(operands.Pop().value.ToString());
                    int x = Convert.ToInt32(operands.Pop().value.ToString());
                    string name = operands.Pop().value.ToString();
                    foreach (Circle f in ShapeContainer.figureList)
                    {
                        if (f.name == name)
                        {
                            figure = (Circle)f;
                        }
                    }
                    if (figure != null)
                    {
                        if (Init.Check_coord(figure.x + x, figure.y + y, figure.w, figure.h, false))
                        {
                            figure.MoveTo(x, y);
                            comboBox1.Items.Add($"Фигура {figure.name} успешно перемещена");
                        }
                        else
                        {
                            MessageBox.Show($"Фигура вышла за границы.");
                            comboBox1.Items.Add("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        comboBox1.Items.Add($"Фигуры {name} не существует");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор M принимает 3 аргумента.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора M.");
                }
            }
            else if (op.symbolOperator == 'D')
            {
                if (operands.Count == 1)
                {
                    Circle figure = null;
                    string name = operands.Pop().value.ToString();
                    foreach (Circle f in ShapeContainer.figureList)
                    {
                        if (f.name == name)
                        {
                            figure = (Circle)f;
                        }
                    }
                    if (figure != null)
                    {
                        figure.DeleteF(figure, true);
                        comboBox1.Items.Add($"Фигура {figure.name} удалена.");
                    }
                    else
                    {
                        comboBox1.Items.Add($"Фигуры {name} не существует.");
                    }
                }
                else
                {
                    MessageBox.Show("Опертор D принимает 1 аргумент.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора D.");
                }
            }
            else if (op.symbolOperator == 'N')
            {

                if (operands.Count == 1)
                {
                    Random rnd = new Random();
                    int n = Convert.ToInt32(operands.Pop().value.ToString());
                    for (int i = 0; i < n; i++)
                    {
                        char a = (char)rnd.Next(0x0061, 0x007A);
                        string name = a.ToString(); // рандом символ 
                        bool k = true;
                        foreach (Circle f in ShapeContainer.figureList)
                        {
                            if (f.name == name)
                            {
                                k = false;
                            }
                        }
                        while (!k) // если есть, пока не найдем уникальное, ищем
                        {
                            bool z = true;
                            char a_temp = (char)rnd.Next(0x0061, 0x007A);
                            string name_temp = a_temp.ToString();
                            foreach (Circle f in ShapeContainer.figureList)
                            {
                                if (f.name == name_temp)
                                {
                                    z = false;
                                }
                            }
                            if (z) name = name_temp; k = true; // нашли
                        }
                        int x = rnd.Next(101, 400);
                        int y = rnd.Next(101, 400);
                        int r = rnd.Next(0, 100);
                        if (Init.Check_coord(x, y, r, r, true))
                        {
                            k = true;
                        }
                        else k = false;
                        while (!k)
                        {
                            int x_temp = rnd.Next(0, 300);
                            int y_temp = rnd.Next(0, 300);
                            int r_temp = rnd.Next(0, 100);
                            if (Init.Check_coord(x_temp, y_temp, r_temp, r_temp, true))
                            {
                                x = x_temp; y = y_temp; r = r_temp;
                                k = true;
                            }
                        }
                        Figure figure = new Circle(x, y, r, name.ToString());
                        op = new Operator(figure.Draw, 'C');
                        ShapeContainer.AddFigure(figure);
                        comboBox1.Items.Add($" Фигура {figure.name} создана");
                        op.operatorMethod();
                    }
                }
                else
                {
                    MessageBox.Show("Опертор N принимает 1 аргумент.");
                    comboBox1.Items.Add("Неверное число аргументов для оператора D.");
                }
            }
        }

    }
}
