using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day5_Assignment
{
    internal class SwapNumber
    {
        public static void swapMethod()
        {
            Console.WriteLine();
            Console.WriteLine("Swap number Program begins from here..................................");
            int temp;
            Console.WriteLine("Enter any value for First number ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter any value for Second number ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now press 1 for SWAPPING NUMBER");
            int z = Convert.ToInt32(Console.ReadLine());

            if (z == 1)
            {
                temp = x;
                x = y;
                y = temp;
                Console.WriteLine("After SWAPPING, First Number : {0} & Second Number : {1}", x, y);
            }
            else
            {
                Console.WriteLine("You did not enter 1");
            }
        }

    }
}
