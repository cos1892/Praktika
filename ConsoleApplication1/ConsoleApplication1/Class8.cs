using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Alstromeria : Flower
    {
        //Конструктор
        public Alstromeria(string name, int cost, int stalk)
            : base(name, cost, stalk) {}

        public override string Name
        {
            get
            {
                return base.Name;
            }
            set
            {
                base.Name = "Альстромерия";
            }
        }

    }
}
