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
            Flower[] flowers = new Flower[5]
            {
                new Rose("",120,20),
                new Lily("",100,25),
                new Iris("",90,30),
                new Rose("",150,26),
                new Iris("",120,40)
            };
 
            Console.WriteLine("***** Букет цветов *****\n");
            foreach (Flower f in flowers)
            {
                f.Show();
            }
            Console.ReadLine();
        }
    }
}
