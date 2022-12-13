using System.Collections.Generic;
using System.Linq;

namespace DotNetLearning.ArrayTask
{
    public class ArrayTasks
    {
        public int GetElementIndex(int[] array, int element)
        {
            int value = Array.IndexOf(array, element);
            return value;
        }

        public int[] InvertArray(int[] array)
        {
            Array.Reverse(array);
            int[] result = array;
            return result;
        }

        public long GetArrayElementSum(int[] array)
        {
            int sum = array.Sum();
            return sum;
        }

        public int[] ArrayConcatenation(int[] array, int[] secondArray)
        {
            int[] result = new int[array.Length + secondArray.Length];
            array.CopyTo(result, 0);
            secondArray.CopyTo(result, array.Length);
            //int[] result = array.Concat(secondArray).ToArray();
            return result;
        }
    }
}
