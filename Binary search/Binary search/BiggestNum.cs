using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    internal class BiggestNum
    {
        public int FindNum(int [] anArray)
        {
            int mx = 0;
            int i;
            for (i = 1; i < anArray.Length; i++)
            {
                if (anArray[i] > mx)
                {
                    mx = anArray[i];
                    
                }
                
            }
            return mx;
            
        }
    }
}
