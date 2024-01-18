using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    internal class PrintHistogram
    {
        public static void PrintHist(int[] results)
        {

            // calculate total rolls
            int totalRolls = results.Sum();

            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + totalRolls + ".\n");

            for (int i = 2; i <= 12; i++)
            {
                //calculate the percentage
                double percentage = (double)results[i] / totalRolls * 100;

                //print the actual histogram
                int asteriskCount = (int)Math.Round(percentage / 1);
                Console.Write($"{i}: {new string('*', asteriskCount)}\n");
            }
        }
    }
}
