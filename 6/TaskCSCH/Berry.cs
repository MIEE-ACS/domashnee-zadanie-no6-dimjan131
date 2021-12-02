using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCSCH
{
    //ягода
    public abstract class Berry : GardenPlant
    {
        int weight;

        public int Weight
        {   get { return weight; }
            set { if (value <= 0) throw new ArgumentException("Не верно задан вес!"); weight = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ", Вес: " + weight;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Berry p = (Berry)obj;
                return (Yield == p.Yield) && (FruitСolor == p.FruitСolor) && (RipeningTime == p.RipeningTime) && (Weight == p.Weight);
            }
        }
    }
}
