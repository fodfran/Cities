using System;
using System.Collections.Generic;

namespace Cities.Comparers
{
    public class CompoundComparer : IComparer<City>
    {
        public IList<IComparer<City>> Comparers = new List<IComparer<City>>();

        public int Compare(City x, City y)
        {
            if (Comparers[0].Compare(x, y) == 0)
            {
                return Comparers[1].Compare(x, y);
            }
            return Comparers[0].Compare(x, y);
        }
    }
}
