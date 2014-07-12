using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Flower
    {
        //Свойства
        public string Name { get; set; }
        public virtual int Cost { get; set; }
        public int StalkLength { get; set; }

        //Конструктор
        public Flower(string name, int cost, int stalk)
        {
            Name = name;
            Cost = cost;
            StalkLength = stalk;
        }
        public void Show()
        {
            Console.WriteLine("Название цветка: " + Name + "; Длина стебля: " + StalkLength + "; Цена: " + Cost + ".\n");
        }
    }
}
