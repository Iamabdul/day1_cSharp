using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("whats my number betwen 1 and 10");
            //declaring a random variable as a new instance of the random method/function
            Random rand = new Random();
            //converting the rand variable into an integer by declaring it as part of an integer function, hence rand.Next(1,10) first number minum, second number maximum.
            int randNumb = rand.Next(1, 10);
            //this creates a global scope of a variable to be used in other functions
            string myNumber;
            int userInput;

            do
            {
                //we must recreate the variables mentioned in the global scope each time the loop itterates through the if statement to create the same condition over and over
                myNumber = Console.ReadLine();
                userInput = Convert.ToInt32(myNumber);

                if (userInput == randNumb)
                {
                    Console.WriteLine("We lit!");
                }
                else if (userInput > randNumb)
                {
                    Console.WriteLine("Lower!");
                }
                else if (userInput < randNumb)
                {
                    Console.WriteLine("higher");
                }

            }
            //keeps loop running as long as user input is not the same as the random number generated
            while (userInput != randNumb);
             Console.ReadLine();



        }
    }
}
