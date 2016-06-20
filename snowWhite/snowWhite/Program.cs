using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            //starting string to make more sense
            Console.WriteLine("Hello there dwarves, I am snow white");
            //declared an array of strings for the dwarves' names, ALWAYS in curly braces
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            //for each string (individual) in (sevenDwarves), {type "how are you" + (individual)}
            for (int i = 0; i < sevenDwarves.Length; i ++)
            {
                Console.WriteLine("How are you " + sevenDwarves[i] + "?");
            }
            //same as above but for a different string
            foreach (string i in sevenDwarves)
            {
                Console.WriteLine("I hope all is well with you, " + i + "?");
            }
            //read it out to the program and by puttin soace for an input
            Console.ReadLine();
        }
    }
}
