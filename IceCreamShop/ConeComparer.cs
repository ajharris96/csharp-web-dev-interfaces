using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public ConeComparer()
        {
        }
        public int Compare(Cone x, Cone y)
        {

            if (y.Cost > x.Cost)
            {
                return -1;
            }
            else if (y.Cost < x.Cost)
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
