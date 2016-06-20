using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While Loop");
            //declaring a number int = 0
            int x = 0;
            //performing the do while statment
            do
            {
                //tells the program to write the value of x
                Console.WriteLine(x);
                //increments the value of x 
                x++;
            }
            //the do while statement will itterate/loop until the value of x is 5 or 1 lower
            while (x < 5);

            //finishing with a readLine statment to make it more visiable to the user
            Console.ReadLine();
        }
        
    }
}
