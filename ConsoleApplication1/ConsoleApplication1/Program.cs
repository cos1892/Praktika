﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массив (букет) цветов
            Flower[] flowers = new Flower[7]
            {
                new Rose("",100,20),
                new Lily("",90,25),
                new Iris("",140,30),
                new Tulpan("",110,30),
                new Alstromeria("",150,30),
                new Hrizantema("",120,25),
                new Gvozdika("",110,35)
            };

            Console.WriteLine("***** Букет цветов несортированный *****\n");
            foreach (Flower f in flowers)
            {
                f.Show();
            }

            //Сортируем массив
            Array.Sort(flowers);

            Console.WriteLine("***** Букет цветов отсортированный *****\n");
            foreach (Flower f in flowers)
            {
                f.Show();
            }

            Cost_Buket cost = new Cost_Buket();
            cost.perform(flowers, 7);

            IEnumerable<Flower> result = new SearchFlower(flowers).Search(flowers, 100, 120);

            Console.WriteLine("***** Результат поиска *****\n");
            foreach (Flower item in result)
            {
                item.Show();
            }

            Console.ReadLine();
        }
    }
}
