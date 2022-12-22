using System.Diagnostics;

namespace Binary_search
{
    internal class Program
    {
        static int Search2(int[] array, int searchedValue, int left, int right)
        {

            while (left <= right)
            {

                int middle = (left + right) / 2;

                if (searchedValue == array[middle])
                {
                    return middle;
                }
                else if (searchedValue < array[middle])
                {

                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            BinarySearch search = new BinarySearch();
            Console.WriteLine("*****Let's try binary search******");

            Console.WriteLine("Please, wright first value of Array");
            int startValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter the number we are looking for");
            int searchingValue = int.Parse(Console.ReadLine());

            int[] newArray = new int[100000];

            for (int i = 0; i < newArray.Length; i++)
            {newArray[i] = startValue;
                startValue ++;
            }

            
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //int value = Search2(newArray, searchingValue, newArray[0], newArray.Length);
            int value = search.Search(newArray, searchingValue, newArray[0], newArray.Length);
            stopWatch.Stop();
            Console.WriteLine($"We are looking for: {value}");
            Console.WriteLine($"Binary search runing: { stopWatch.Elapsed}") ;

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            int value2 = Array.IndexOf(newArray, searchingValue);
            Console.WriteLine($"We are looking for: {value2}");
            stopWatch2.Stop();
            Console.WriteLine($"Simple search runing: {stopWatch2.Elapsed}");
        }

    }
}