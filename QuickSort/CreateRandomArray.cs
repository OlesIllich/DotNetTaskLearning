using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class CreateRandomArray
    {
        public int[] GetRandomArray(int length, int minValue, int maxValue)
        {
            int[] array = new int[length];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    array[i] = r.Next(minValue, maxValue);
                }
                
            }

            return array;
        }
    }
}
