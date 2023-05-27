using Lab21.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21.View
{
    public class PriceDescendingComparer : IComparer<Sweet>
    {
        public int Compare(Sweet x, Sweet y)
        {
            if (x == null)
            {
                return y == null ? 0 : -1;
            }

            if (y == null)
            {
                return 1;
            }

            return y.Price.CompareTo(x.Price);
        }
    }
    public class PriceAscendingComparer : IComparer<Sweet>
    {
        public int Compare(Sweet x, Sweet y)
        {
            if (x == null)
            {
                return y == null ? 0 : -1;
            }

            if (y == null)
            {
                return 1;
            }

            return x.Price.CompareTo(y.Price);
        }
    }
}
