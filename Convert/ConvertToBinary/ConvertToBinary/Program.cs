﻿namespace ConvertToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose operatoin and write 1 or 2");
            Console.WriteLine("1 - convert decimal to binary");
            Console.WriteLine("2 - convert binary to decimal");
            int variant;
            bool success = int.TryParse(Console.ReadLine(), out variant);
            while (!success)
            {
                Console.WriteLine("It is uncorrect value");
                success = int.TryParse(Console.ReadLine(), out variant);
            }

            switch (variant)
            {
                case 1:
                ToBinary toBinary = new ToBinary();
                toBinary.ConvertToBinary();
                break;
                case 2:         
                ToInt toInt = new ToInt();
                toInt.ConvertToInt();
                break;
                default:
            Console.WriteLine($"I cant understend you)");
                break;
        }
        }
    }
}