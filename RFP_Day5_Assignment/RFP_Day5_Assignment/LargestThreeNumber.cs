using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day5_Assignment
{
    internal class LargestThreeNumber
    {

        public static void bubbleSortMethod()
        {
            Console.WriteLine();
            Console.WriteLine("Largest Number Finding Program begins from here..................................");
            int temp;
            int[] NumberArray = new int[3];
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter number " + i);
                NumberArray[i - 1] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j <= NumberArray.Length - 2; j++)
            {
                for (int k = 0; k <= NumberArray.Length - 2; k++)
                {
                    if (NumberArray[k] > NumberArray[k + 1])
                    {
                        temp = NumberArray[k + 1];
                        NumberArray[k + 1] = NumberArray[k];
                        NumberArray[k] = temp;
                    }
                }

            }
            Console.WriteLine("Smallest number : {0} & Largest number : {1} ", NumberArray[0], NumberArray[2]);
        }
    }
}

