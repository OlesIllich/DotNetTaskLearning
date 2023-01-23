namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter min value of Array");
            int minValue;
            bool success1 = int.TryParse(Console.ReadLine(), out minValue);
            while (!success1)
            {
                Console.WriteLine("It is uncorrect value");
                success1 = int.TryParse(Console.ReadLine(), out minValue);
            }

            Console.WriteLine("Please, enter max value of Array");
            int maxValue;
            bool success2 = int.TryParse(Console.ReadLine(), out maxValue);
            while (!success2)
            {
                Console.WriteLine("It is uncorrect value");
                success2 = int.TryParse(Console.ReadLine(), out maxValue);
            }

            Console.WriteLine("What number of items in array do you want?");
            int lengthOfArray;
            bool success3 = int.TryParse(Console.ReadLine(), out lengthOfArray);
            while (!success3)
            {
                Console.WriteLine("It is uncorrect value");
                success3 = int.TryParse(Console.ReadLine(), out lengthOfArray);
            }

            CreateRandomArray createRandomArray = new CreateRandomArray();

            int[] myArray = createRandomArray.GetRandomArray(lengthOfArray, minValue, maxValue);

            WrightArray wrightArray = new WrightArray();

            Console.WriteLine("This is our array:");
            wrightArray.Wright(myArray);

            var sortBy = new SortByPartisipation();

            int [] newArray = sortBy.SortArray(myArray, 0, myArray.Length -1 );

            Console.WriteLine("This is our sorted array:");
            wrightArray.Wright(myArray);
        }
    }
}