using System;
using System.Collections.Generic;
using System.Text;

namespace lv7.components
{
    //2.zad
    class BinarySearch : SearchStrategy
    {
        public override void Search(double[] array, double key)
        {
            int myIndex = Array.BinarySearch(array, key);
            if (myIndex < 0)
            {
                Console.WriteLine("The number to search for ({0}) is not found. The next larger object is at index {1}.", key, ~myIndex);
            }
            else
            {
                Console.WriteLine("The number to search for ({0}) is at index {1}.", key, myIndex);
            }
        }
    }
}
