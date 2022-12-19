using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form0 form0 = new Form0();
            form0.Show();
        }

        public bool validData() //проверка правильности ввода
        {
            try
            {
                if (textBox_name.Text == "") { labelErrorName.Visible = true; return false; }
                if (!textBox_date.MaskFull) { labelErrorDate.Visible = true; return false; } else { labelErrorDate.Visible = false; }
                if (double.Parse(textBox_cost.Text) <= 0) { labelErrorCost.Visible = true; return false; } else { labelErrorCost.Visible = false;}
                if (int.Parse(textBox_count.Text) <= 0) { labelErrorCount.Visible = true; return false; } else { labelErrorCount.Visible=false; }
                if (!textBox_numb.MaskFull) { labelErrorNumb.Visible = true; return false; } else { labelErrorNumb.Visible = false; }

            }
            catch(FormatException)
            {
                return false;
            }
            return true;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        { 
            labelCreated.Visible = false;
            labelErrorDid.Visible = false;
            labelErrorCreate.Visible = false;
            if (validData())
            {
                

                string nameF = textBox_name.Text;
                string dateF = textBox_date.Text;
                double costF = double.Parse(textBox_cost.Text);
                int countF = int.Parse(textBox_count.Text);
                int numbF = int.Parse(textBox_numb.Text);
                bool ok = true;
                foreach (Goods item in Goods.listGoods)
                {
                    if (nameF == item.nameG)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    Goods good = new Goods(nameF, dateF, costF, countF, numbF);
                    labelCreated.Visible = true;
                    
                }
                else
                {
                    labelErrorDid.Visible = true;
                }
            }
            else
            {
                labelErrorCreate.Visible = true;
            }
        
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox_nameall.Text;
            bool ok = true;
            labelNotFound.Visible = false;
            foreach (Goods item in Goods.listGoods)
            {
                if (name == item.nameG)
                {
                    ok = false;
                    groupBox3.Visible = true;
                    textBoxn.Text = item.nameG;
                    textBoxc.Text = (item.costG).ToString();
                    textBoxk.Text = (item.countG).ToString();
                    textBoxall.Text = (item.allCost()).ToString();
                    break;

                }
            } if (ok)
            {
                labelNotFound.Visible = true;
                groupBox3.Visible = false;
            }
            
        }

        private void textBox_cost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelErrorCost.Visible= false;
                double costF = double.Parse(textBox_cost.Text);
                if (costF <= 0)
                {
                    labelErrorCost.Visible = true;
                }

            }
            catch (FormatException)
            {
                labelErrorCost.Visible = true;
            }
        }

        private void textBox_count_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelErrorCount.Visible = false;
                int countF = int.Parse(textBox_count.Text);
                if (countF <= 0)
                {
                    labelErrorCount.Visible = true;
                }
            }
            catch (FormatException)
            {
                labelErrorCount.Visible = true;

            }
        }

        private void textBox_numb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelErrorNumb.Visible = false;
                int numbF = int.Parse(textBox_numb.Text);
            }
            catch (FormatException)
            {
                labelErrorNumb.Visible= true;
            }
           
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelErrorName.Visible = false;
                string nameF = textBox_name.Text;
                if (nameF.Length == 0)
                {
                    labelErrorName.Visible = true;
                }
            }
            catch (FormatException)
            {
                labelErrorName.Visible = true;
            }
        }

        private void textBox_date_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string nameF = textBox_name.Text;
            if (nameF == "")
            {
                labelErrorName.Visible = true;
            }
        }

        public bool validNewData()
        {
            try
            {
                if (textBoxNewcost.Text != "" & double.Parse(textBoxNewcost.Text) < 0) { labelErrorNewcost.Visible = true; return false; } else { labelErrorNewcost.Visible = false;}
                if (textBoxNewcount.Text != "" & double.Parse(textBoxNewcount.Text) < 0) { labelErrorNewcount.Visible = true; return false; } else { labelErrorNewcount.Visible = false;}
            }
            catch(FormatException) {
                return false;
            }
            return true;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox_name.Text;
            bool ok = false;
            bool k = false;
            labelErrorNotFaunded.Visible = false;
            labelErrorNewcount.Visible = false;
            labelErrorNewcost.Visible = false;
            labelEditedComplited.Visible = false;
                foreach (Goods item in Goods.listGoods)
                {
                    if (s == item.nameG)
                    {
                        ok = true;
                        if (textBoxNewcost.Text.Length != 0)
                        {
                            try
                            {
                                double newCost = double.Parse(textBoxNewcost.Text);

                                item.changeCost(newCost);
                                k = true;
                            }
                            catch (FormatException)
                            {
                                labelErrorNewcost.Visible = true;
                            }
                        }
                        if (textBoxNewcount.Text.Length != 0)
                        {
                            try
                            {
                                int newCount = int.Parse(textBoxNewcount.Text);
                                item.changeCount(newCount);
                                k = true;
                            }
                            catch (FormatException)
                            {
                                labelErrorNewcount.Visible = true;
                            }
                        }
                        break;
                    }
                }
                if (!ok)
                {
                    labelErrorNotFaunded.Visible = true;
                }
                if (k)
                {
                    labelEditedComplited.Visible = true;
                }
            
        }

        private void textBoxNewcost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelErrorNewcost.Visible=false;
                double cost = double.Parse(textBoxNewcost.Text);

            }
            catch
            {
                labelErrorNewcost.Visible=true;
            }
        }

        private void textBoxNewcount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                labelErrorNewcount.Visible = false;
                double count = double.Parse(textBoxNewcost.Text);

            }
            catch
            {
                labelErrorNewcount.Visible = true;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBoxc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
