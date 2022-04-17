using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day5_Assignment
{
    internal class Leapyear
    {
        public static int Year;

        public static void checkYearInput()
        {
            Console.WriteLine("Enter any year");
            Year = Convert.ToInt32(Console.ReadLine());
            if (Year / 1000 != 0 && Year / 1000 < 10)
            {
                Console.WriteLine("Entered number is four digit number ");
            }
            else
            {
                Console.WriteLine("Entered number is not four digit number ");
            }
        }
        public static void Yearmethod()
        {
            Console.WriteLine();
            Console.WriteLine("Leap year Program begins from here..................................");
            checkYearInput();

            if (Year / 1000 != 0 && Year / 1000 < 10)
            {
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {
                    Console.WriteLine("{0} is leap year", Year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year", Year);
                }
                Console.WriteLine("Leap year program ends here.......................................");
            }
        }
    }
}
