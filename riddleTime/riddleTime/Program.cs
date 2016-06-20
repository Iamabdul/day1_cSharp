using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riddleTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what runs but doesnt walk, has a mouth that doesnt talk");
            string theAnswer="";
            string secondAnswer ="";
            int trys = 0 ;
            //"while the answer is not the river or water 
            while ((theAnswer != "river") || (theAnswer != "water"))
            {
            theAnswer = (Console.ReadLine()).ToLower();
                trys = Convert.ToInt32(trys);
                switch (theAnswer)
                {
                    //more thean one condition to satisfy one result
                    case "river":
                    case "water":
                        Console.WriteLine("you got one right!");
                        Console.WriteLine("Next riddle, what am I");
                        break;
                    case "Y":
                        Console.WriteLine("alright hand over your badge sissy");
                        break;
                    case "N":
                        Console.WriteLine("lets keep going!");
                        break;
                    default:
                        Console.WriteLine("you got this, press Y to quit or N to move on");
                        break;                        
                }
                //at the end of every loop, the trys variable increments by one each time, hence increasing the value of "trys" per guess
                trys++;
                Console.WriteLine("current trys: " + trys);
                
            }

            do
            {
                Console.WriteLine("Next Question");
                secondAnswer = (Console.ReadLine()).ToLower();
                switch (secondAnswer)
                {
                    case "i am":
                        Console.WriteLine("you are too good");
                        break;
                    default:
                        Console.WriteLine("keep it up man");
                        break;
                }
                trys++;
            } while (secondAnswer != "i am") 

            Console.WriteLine("total trys for the whole game: " + trys);
            Console.ReadLine();


        }
    }
}
