using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring the integer array of the name "numbers" as a "new" instance of this integer array, with a restriction of 5 entries
            int[] numbers = new int[5];
            //we need to keep the average variable a double as the average may have some decimals and needs to be flexible.
            double average;
            //the total sum of entries will always start at 0 as we have entered nothing at the start
            int total = 0;
            //the last comma in the brackets makes sure to incremement the individual entries of the array
            for (int i = 0; i < numbers.Length; i ++)
            {
                Console.WriteLine("Enter a number ");
                //convert the numbers written in the readLine box as an integer 
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            //another for loop to keep looping for what ever we add from the first loop
            //the first loop runs 5 times, while that happens, the second loop keeps track of the numbers entry
            for (int i = 0; i < numbers.Length; i++)
            {
                //keeps adding the numbers int together for the total sum
                total += numbers[i];
            }
            //calculates the average of all entries
            average = total / (double)numbers.Length;

            Console.WriteLine("Average = {0}", average);

            Console.ReadLine();
        }
    }
}
