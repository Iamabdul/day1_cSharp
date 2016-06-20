using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there, what number am I thinking of between 9 and 11?");

            string userInput = Console.ReadLine();
            int numberGuess = Convert.ToInt32(userInput);

            //if statement using assignment operator, need to remember it is a == not a =, = assisgns a value to a variable string.
            if (numberGuess == 10)
            {
                Console.WriteLine("Well done, it was 10!");
            }
            //if else statment used same as JS
            else if (numberGuess > 10)
            {
                Console.WriteLine("Lower");
            }

            else if (numberGuess < 10)
            {
                Console.WriteLine("higher");
            }

            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
