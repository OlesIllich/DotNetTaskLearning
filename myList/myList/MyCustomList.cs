using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace myList
{
    internal class MyCustomList<T> : IEnumerable <T>
    {
        public T[] _array = Array.Empty<T>();

        public T this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        public int Count { get { return _array.Length; } }

      

        public void Add(T Value)
        {
            var newArray = new T[_array.Length +1];

            for (int i = 0; i < _array.Length; i++) 
            {
                newArray[i] = _array[i];
            }
            newArray[_array.Length] = Value;
            _array = newArray;
        }

        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }

        public void Remove(int index)
        {
            var newArray = new T[_array.Length - 1];
                var i = 0;
                int j = 0;
                while (i < _array.Length)
                {
                    if (i != index )
                    {
                        newArray[j] = _array[i];
                        j++;
                    }
                    i++; 
                }
           
            _array = newArray;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }
    }

}
