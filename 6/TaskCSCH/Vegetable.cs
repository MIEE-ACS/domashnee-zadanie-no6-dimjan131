using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCSCH
{
    //овощ
    public abstract class Vegetable: GardenPlant
    {
        //размер
        int size;
        public int Size
        {
            get { return size; }
            set { if (value <= 0) throw new ArgumentException("Не верно задан размер!"); size = value; }
        }

        public override string ToString()
        {
            return base.ToString() + ", Размер: " + Size;
        }
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Vegetable p = (Vegetable)obj;
                return (Yield == p.Yield) && (FruitСolor == p.FruitСolor) && (RipeningTime == p.RipeningTime) && (Size == p.Size);
            }
        }
    }
}
