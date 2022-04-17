using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day5_Assignment
{
    internal class EvenOdd
    {

        //it can also be done without array easily 

        public static int x;
        public static void evenOddMethod()
        {
            Console.WriteLine();
            Console.WriteLine("Even Odd Program begins from here..................................");
            Console.WriteLine("Enter the number till you want to find out Even odd number ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] evenOddArray = new int[x];
            for (int i = 1; i <= x; i++)
            {
                int y = i - 1;
                evenOddArray[y] = i;
            }
            for (int j = 1; j <= x; j++)
            {
                int z = j - 1;
                if (x == 0)
                {
                    Console.WriteLine("You entered zero number");
                }
                if (j % 2 == 0)
                {
                    Console.WriteLine(evenOddArray[z] + " : Even number");
                }
                else
                {
                    Console.WriteLine(evenOddArray[z] + " : Odd number");
                }

            }

        }
    }
}
