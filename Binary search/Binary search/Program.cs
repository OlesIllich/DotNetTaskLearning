using System.Diagnostics;

namespace Binary_search
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            BinarySearch search = new BinarySearch();
            Console.WriteLine("*****Let's try binary search******");

            Console.WriteLine("Please, wright first value of Array");
            int startValue;
            bool success1 = int.TryParse(Console.ReadLine(),out startValue);
            if (success1) { }
            else
            {
                Console.WriteLine("It is uncorrect value");
                return;
            }

            Console.WriteLine("Please, enter the number we are looking for");
            int searchingValue; 
            bool success2 = int.TryParse(Console.ReadLine(), out searchingValue);
            if (success2) { }
            else
            {
                Console.WriteLine("It is uncorrect value");
                return;
            }

            Console.WriteLine("What number of items in array do you want?");
            int lengthOfArray;
            bool success3 = int.TryParse(Console.ReadLine(), out lengthOfArray);
            if (success3) { }
            else
            {
                Console.WriteLine("It is uncorrect value");
                return ;
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


                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                //int value = Search2(newArray, searchingValue, newArray[0], newArray.Length);
                int value = search.Search(newArray, searchingValue);
                stopWatch.Stop();
                Console.WriteLine($"We are looking for: {value}");
                Console.WriteLine($"Binary search runing: {stopWatch.Elapsed}");

                Stopwatch stopWatch2 = new Stopwatch();
                stopWatch2.Start();
                int value2 = Array.IndexOf(newArray, searchingValue);
                Console.WriteLine($"We are looking for: {value2}");
                stopWatch2.Stop();
                Console.WriteLine($"Simple search runing: {stopWatch2.Elapsed}");
            }
           
        }

    }
}