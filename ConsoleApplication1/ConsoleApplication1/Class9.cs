using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cost_Buket
    {
        public void perform(Array flowers, int kolvo)
        {
            Flower[] arr = new Flower[kolvo];

            int Stoimost = 0;

            foreach (Flower f in flowers)
            {
                Stoimost += f.Cost;
            }
            Console.WriteLine("***** Стоимость данного букета=" + Stoimost + " руб. *****\n");
        }
    }
}
