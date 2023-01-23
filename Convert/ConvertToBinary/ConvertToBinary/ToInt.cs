using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToBinary
{
    internal class ToInt
    {
        internal void ConvertToInt()
        {
            Console.Write("Enter the binary number to convert: ");
            int binaryNumber;
            bool success1 = int.TryParse(Console.ReadLine(), out binaryNumber);
            while (!success1)
            {
                Console.WriteLine("It is uncorrect value");
                success1 = int.TryParse(Console.ReadLine(), out binaryNumber);
            }
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            Console.Write($"Decimal Value : {decimalValue} ");
        }
    }
}
