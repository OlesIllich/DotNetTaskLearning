using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_search
{
    internal class SpecificSearch
    {
        private readonly SearchBase _search;

        public SpecificSearch(SearchBase search)
        {
            _search = search;
        }

        public int Search(int[] array, int searchingValue)
        {
            return _search.Search(array, searchingValue);
        }
    }
}
