using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class SearchFlower
    {
        private ICollection<Flower> Array{ get; set; }

        public SearchFlower(ICollection<Flower> array)
        {
            this.Array = array;
        }

        public IEnumerable<Flower> Search(IList<Flower> array, double minValue, double maxValue)
        {
            IEnumerable<Flower> result = from item in Array
                                         where ((item.Cost >= minValue) && (item.Cost <= maxValue))
                                            select item;
            return result;

        }
    }
}
