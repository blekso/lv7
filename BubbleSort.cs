using System;
using System.Collections.Generic;
using System.Text;

namespace lv7.components
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i+1]);
                    }
                }
            }
        }
    }

}
