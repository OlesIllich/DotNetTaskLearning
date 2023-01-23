using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    internal class SimpleSearch : SearchBase
    {
        internal override int Search(int[] inputArray, int key)
        {
           return Array.IndexOf(inputArray, key);
        }
    }
    
}
