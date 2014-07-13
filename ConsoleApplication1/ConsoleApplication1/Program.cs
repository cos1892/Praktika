using System;
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
                new Rose("",120,20),
                new Lily("",100,25),
                new Iris("",90,30),
                new Tulpan("",110,30),
                new Iris("",90,30),
                new Rose("",150,26),
                new Gvozdika("",120,35)
            };
 
            Console.WriteLine("***** Букет цветов *****\n");
            foreach (Flower f in flowers)
            {
                f.Show();
            }

            int Stoimost=0;
                        
            foreach (Flower f in flowers)
            {
                Stoimost = Stoimost + f.Cost;
            }
            Console.WriteLine("***** Стоимость данного букета=" + Stoimost+ " руб. *****\n");

            Console.ReadLine();
        }
    }
}
