using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskCSCH
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            List<GardenPlant> g = new List<GardenPlant>();
            g.Add(new Raspberries(70, "Красный", 70, 3));
            g.Add(new AppleTree(80, "Зеленый", 70, 500));
            g.Add(new Potatoes(20, "Желтый", 70, 3));
            while (true)
            {
                try
                {
                    Console.WriteLine("1 - Добавить");
                    Console.WriteLine("2 - Удалить");
                    Console.WriteLine("3 - Вывести весь список");
                    Console.WriteLine("4 - Три самых урожайных вида");
                    Console.Write("Ваш выбор: ");
                    n = int.Parse(Console.ReadLine());
                    switch(n)
                    {
                        case 1:
                            {
                                Console.WriteLine("1 - Картошка");
                                Console.WriteLine("2 - Малина");
                                Console.WriteLine("3 - Яблоки");
                                Console.Write("Ваш выбор: ");
                                n = int.Parse(Console.ReadLine());
                                if (n >= 1 && n <= 3)
                                {
                                    Console.Write("Урожайность: ");
                                    int u = int.Parse(Console.ReadLine());
                                    Console.Write("Цвет: ");
                                    string c = Console.ReadLine();
                                    Console.Write("Время созревания: ");
                                    int v = int.Parse(Console.ReadLine());
                                    switch (n)
                                    {
                                        case 1:
                                            {
                                                Console.Write("Размер: ");
                                                g.Add(new Potatoes(u, c, v, int.Parse(Console.ReadLine())));
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.Write("Вес: ");
                                                g.Add(new Raspberries(u, c, v, int.Parse(Console.ReadLine())));
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.Write("Кол-во: ");
                                                g.Add(new AppleTree(u, c, v, int.Parse(Console.ReadLine())));
                                                break;
                                            }
                                    }
                                }
                                break; 
                            }
                        case 2: { Console.Write("Введите номер: "); g.RemoveAt(int.Parse(Console.ReadLine())); break; }
                        case 3: { g=g.OrderBy(x=>x.RipeningTime).ToList(); for (int i = 0; i < g.Count; i++) Console.WriteLine(g[i].ToString());  break; }
                        case 4: { g = g.OrderBy(x => x.Yield).ToList(); for (int i = g.Count-1, j=0; i >0 && j<3; i--, j++) Console.WriteLine(g[i].ToString()); break; }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }

    class AppleTree:FruitTree
    {
        public AppleTree(int Yield, string FruitСolor, int RipeningTime, int Сount)
        {
            this.Yield = Yield;
            this.FruitСolor = FruitСolor;
            this.RipeningTime = RipeningTime;
            this.Сount = Сount;
        }
    }

    class Raspberries : Berry
    {
        public Raspberries(int Yield, string FruitСolor, int RipeningTime, int Weight)
        {
            this.Yield = Yield;
            this.FruitСolor = FruitСolor;
            this.RipeningTime = RipeningTime;
            this.Weight = Weight;
        }
    }

    class Potatoes : Vegetable
    {
        public Potatoes(int Yield, string FruitСolor, int RipeningTime, int Size)
        {
            this.Yield = Yield;
            this.FruitСolor = FruitСolor;
            this.RipeningTime = RipeningTime;
            this.Size = Size;
        }
    }
}
