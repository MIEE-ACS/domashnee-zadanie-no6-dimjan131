using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCSCH
{
    public abstract class GardenPlant
    {
        int yield;
        string fruitСolor;
        int ripeningTime;
        //урожайность
        public int Yield
        {
            get { return yield; }
            set { if (value <= 0) throw new ArgumentException("Не верно задана урожайность!"); yield = value; }
        }
        public string FruitСolor //цвет плода
         {
            get { return fruitСolor; }
            set { if (string.IsNullOrEmpty(value)) throw new ArgumentException("Не верно задан цвет!"); fruitСolor = value; }
        }
        public int RipeningTime//время созревания
        {
            get { return ripeningTime; }
            set { if (value <= 0) throw new ArgumentException("Не верно задано время!"); ripeningTime = value; }
        }

        public override string ToString()
        {
            return "Урожайность: " + yield + ", Цвет плода: " + FruitСolor + ", Время созревания: " + RipeningTime;
        }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                GardenPlant p = (GardenPlant)obj;
                return (yield == p.yield) && (fruitСolor == p.fruitСolor) && (ripeningTime == p.ripeningTime);
            }
        }


    }
}
