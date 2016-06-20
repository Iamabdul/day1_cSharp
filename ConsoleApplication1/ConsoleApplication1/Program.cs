using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //I have used the console.writeLine to add a string
            Console.WriteLine("I am thinking of a particular number");
            //declared userinput as a string to be input by the user
            string userInput = Console.ReadLine();
            //converted the string input into a number  by using the Convert.ToInt32() and then inputting the name of the string variable to be converted within the requesting brackets.
            int number = Convert.ToInt32(userInput);
            //started the usual conditional if statement
            if (number > 8)
            {
                Console.WriteLine("More than 8");
            }
            else
            {
                Console.WriteLine("Less than 8");
            }
            //ended with a ReadLine statment to helkp the user input what they need to for the game
            Console.ReadLine();
        }
    }
}
