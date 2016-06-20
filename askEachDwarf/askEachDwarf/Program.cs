using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace askEachDwarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, I am snow white, what would my dear lovely dwarves like today?");
            //declared an empty string to use later in a for statement
            string askTheDwarves;

            //declared a fixed array fo the seven dwarves
            string [] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            //for statement, showing that the individual base position starts at 0
            //, the first comma shows that as long as the length of loops is less than the array it still runs
            //the second comma shows an increment of the individual 
            for (int i = 0; i<sevenDwarves.Length; i ++)
            {
                Console.WriteLine("what would " + sevenDwarves[i] + " like ?");
                askTheDwarves = Console.ReadLine();
                Console.WriteLine(sevenDwarves[i] + ", your " + askTheDwarves + " is ready!");
            }
            Console.ReadLine();
        }
    }
}
