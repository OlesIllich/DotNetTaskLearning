using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToBinary
{
    internal class ToInt
    {
        public void ConvertToInt()
        {
            Console.Write("Enter the binary number to convert: ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
            Console.Write($"Decimal Value : {decimalValue} ");
        }
    }
}
