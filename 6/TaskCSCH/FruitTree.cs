using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCSCH
{
    //фруктовое дерево
    public abstract class FruitTree : GardenPlant
    {
        int сount; //количество штук на дереве
        public int Сount
        {
            get { return сount; }
            set { if (value <= 0) throw new ArgumentException("Не верно задано количество!"); сount = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ", Кол-во: " + Сount;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                FruitTree p = (FruitTree)obj;
                return (Yield == p.Yield) && (FruitСolor == p.FruitСolor) && (RipeningTime == p.RipeningTime) && (Сount == p.Сount);
            }
        }
    }
}
