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
                new Rose("",100,20),
                new Lily("",90,25),
                new Iris("",140,30),
                new Tulpan("",110,30),
                new Alstromeria("",150,30),
                new Hrizantema("",120,25),
                new Gvozdika("",110,35)
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
