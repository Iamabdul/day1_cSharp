using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace presidents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("who do you think will win?");
            //declared a string for user input, but notice at the end I have used a property of readLine called "to Lower" which ignores any sensitivity that the program may have towards character case.
            string thePresident;
            do
            {
                //always mention the variable you will use from the global scope, 
                thePresident = (Console.ReadLine()).ToLower();
                switch (thePresident)
                {
                    case "obama":
                        Console.WriteLine("what, again?");
                        break;
                    //it can be seen that both cases are in their own colons to represent their own case 
                    case "berny":
                    case "hilary":
                        Console.WriteLine("change is needed");
                        break;
                    case "trump":
                    case "kkk":
                        Console.WriteLine("we are doomed");
                        break;
                    default:
                        Console.WriteLine("Pick a real candidate");
                        break;
                }
                //while "true, if keeps executing, more condition are available
            } while (true);

            //Console.ReadLine();
        }
    }
}
