using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap8.Deck.Business
{
    public class Duck
    {
        public int Size { get; set; }
        public string Name { get; set; }

        private void Ordernar()
        {
            DuckComparer dc = new DuckComparer();
            List<Duck> ducks = new List<Duck>();
            ducks.Sort(dc);
        }
    }

    public class DuckComparer : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Size < y.Size)
            {
                return -1;
            }
            else if (x.Size > y.Size)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
