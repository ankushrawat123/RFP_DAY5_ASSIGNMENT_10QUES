using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day5_Assignment
{
    internal class QuotientRemainder
    {
        public static void quotientRemainderMethod()
        {
            Console.WriteLine();
            Console.WriteLine("Quotient Remainder Finding Program begins from here..................................");
            Console.WriteLine("Enter the Dividend value");
            int divd = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Divisor value");
            int div = int.Parse(Console.ReadLine());
            int remainder = divd % div;
            int quotient = divd / div;
            Console.WriteLine("Quotient value : " + quotient);
            Console.WriteLine("Remainder value : " + remainder);

        }
    }
}
