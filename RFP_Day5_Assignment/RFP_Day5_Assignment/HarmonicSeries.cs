using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day5_Assignment
{
    internal class HarmonicSeries
    {

        public static void harmonicMethod()
        {
            Console.WriteLine();
            Console.WriteLine("Harmonic series Printing Program begins from here..................................");
            Console.WriteLine("Enter the n value for Harmonic Series");
            int n = int.Parse(Console.ReadLine());
            if (n != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("1/{0} + ", i);
                }
            }
            else
            {
                Console.WriteLine("Entered Zero number and you need to enter Non Zero number");
            }
        }
    }
}
