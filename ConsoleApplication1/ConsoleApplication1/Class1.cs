using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Flower : IComparable<Flower>
    {
        //Свойства
        public virtual string Name { get; set; }
        public int Cost { get; set; }
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

        //Реализация интерфейса IComparable<Flower>(для сортировки)
        public int CompareTo(Flower other)
        {
            if ((int)this.StalkLength > (int)other.StalkLength)
                return 1;
            if ((int)this.StalkLength < (int)other.StalkLength)
                return -1;
            else
                return 0;
        }
    }
}
