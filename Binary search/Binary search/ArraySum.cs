using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    internal class ArraySum
    {
        internal int Sum(int[] inputArray, int i = 0)
        {
           
                if (i >= inputArray.Length)
                return 0;
                int result = Sum(inputArray, i + 1);
                return inputArray[i] + result;
                       
        }
    }
}
