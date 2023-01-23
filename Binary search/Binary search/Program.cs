using System.Diagnostics;

namespace Binary_search
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("*****Let's try binary search******");

            Console.WriteLine("Please, wright first value of Array");
            int startValue;
            bool success1 = int.TryParse(Console.ReadLine(),out startValue);
            while (!success1) 
            {
                Console.WriteLine("It is uncorrect value");
                success1 = int.TryParse(Console.ReadLine(), out startValue);
            }

            Console.WriteLine("Please, enter the number we are looking for");
            int searchingValue; 
            bool success2 = int.TryParse(Console.ReadLine(), out searchingValue);
            while (!success2)
            {
                Console.WriteLine("It is uncorrect value");
                success2 = int.TryParse(Console.ReadLine(), out searchingValue);
            }

            Console.WriteLine("What number of items in array do you want?");
            int lengthOfArray;
            bool success3 = int.TryParse(Console.ReadLine(), out lengthOfArray);
            while (!success3)
            {
                Console.WriteLine("It is uncorrect value");
                success3 = int.TryParse(Console.ReadLine(), out lengthOfArray);
            }

            if (startValue > searchingValue)
            { Console.WriteLine("Searching value can not be less then first item of array"); }

            if (startValue <= searchingValue)
            {

                int[] newArray = new int[lengthOfArray];

                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = startValue;
                    startValue++;
                }

                var list = new List<SpecificSearch>();
                var search = new SpecificSearch(new BinarySearch());
                var search2 = new SpecificSearch(new SimpleSearch());
                list.Add(search);
                list.Add(search2);

                foreach (var item in list)
                {
                    var stopWatch = new Stopwatch();
                    stopWatch.Start();
                    int seitemValue = item.Search(newArray, searchingValue);
                    stopWatch.Stop();
                    Console.WriteLine($"We are looking for: {seitemValue}");
                    Console.WriteLine($"Binary search runing: {stopWatch.Elapsed}");
                }

                ArraySum arraySum = new ArraySum();
                int sum = arraySum.Sum(newArray);
                Console.WriteLine($"Sum of array elements = {sum}");

                int big;
                var biggestNum = new BiggestNum();
                big = biggestNum.FindNum(newArray);
                Console.WriteLine($"The biggest num is {big}");

            }
           
        }

    }
}