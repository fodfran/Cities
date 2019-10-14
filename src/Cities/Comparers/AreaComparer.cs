﻿using System;
using System.Collections.Generic;

namespace Cities.Comparers
{
    public class AreaComparer : IComparer<City>
    {

        public int Compare(City x, City y)
        {
            return (int)(y.Area - x.Area);
        }
    }
}
