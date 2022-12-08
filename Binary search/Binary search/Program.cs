using System.Diagnostics;

namespace Binary_search
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            BinarySearch search = new BinarySearch();
            Console.WriteLine("*****Let's try binary search******");
            int[] newArray = new int[100000];

            for (int i = 0; i < newArray.Length; i++)
            {newArray[i] = i;}

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int value = BinarySearch(newArray, 5000, newArray[0], newArray[99999]);
            stopWatch.Stop();
            Console.WriteLine($"We are looking for: {value}");
            Console.WriteLine($"Binary search runing: { stopWatch.Elapsed}") ;

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            int value2 = Array.IndexOf(newArray, 5000);
            Console.WriteLine($"We are looking for: {value2}");
            stopWatch2.Stop();
            Console.WriteLine($"Simple search runing: {stopWatch2.Elapsed}");
        }

    }
}