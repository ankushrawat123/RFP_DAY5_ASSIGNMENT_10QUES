using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day5_Assignment
{
    internal class Powof2
    {
        public static int n;
        public static int i = 0;
        public static int num = 1;
        public static int powmethod()
        {

            Console.WriteLine("Enter value of n for calculating 2^n");
            n = Convert.ToInt32(Console.ReadLine());
            if (n >= 31)
            {
                Console.WriteLine("This 2^n Power Program works for number less than 31 ");
            }
            return n;
        }
        public static void method()
        {
            Console.WriteLine();
            Console.WriteLine("Power of 2 Program begins from here..................................");
            powmethod();

            if (n < 31)
            {
                while (i < n)
                {
                    i++;
                    num = num * 2;
                }
                Console.WriteLine("Value of 2^{0} is {1}", n, num);
            }
        }
    }
}
