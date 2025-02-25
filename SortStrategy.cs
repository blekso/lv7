﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lv7.components
{
    abstract class SortStrategy
    {
        public abstract void Sort(double[] array);
        protected void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }

}
