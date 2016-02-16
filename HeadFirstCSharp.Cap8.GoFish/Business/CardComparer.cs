using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap8.GoFish.Business
{
    public class CardComparer : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value)
            {
                return 1;
            }
            else if (x.Value < y.Value)
            {
                return -1;
            }
            else
            {
                if (x.Suit > y.Suit)
                {
                    return 1;
                }
                else if (x.Suit < y.Suit)
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
