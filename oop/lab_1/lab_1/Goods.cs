using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Goods
    {
        public string nameG;
        public string dateG;
        public double costG;
        public int countG;
        public int numbG;

        

        public Goods(string _name, string _date, double _cost, int _count, int _numb)
        {
            this.nameG = _name;
            this.dateG = _date;
            this.costG = _cost;
            this.countG = _count;
            this.numbG = _numb;
            listGoods.Add(this);
        }
        public static List<Goods> listGoods = new List<Goods>();

        

        public void changeCost (double newCost)
        {
            costG = newCost;
        }

        public void changeCount (int newCount)
        {
            countG = newCount;
        }
        public double allCost()
        {
            return costG * countG;
        }
        
    } 
}
