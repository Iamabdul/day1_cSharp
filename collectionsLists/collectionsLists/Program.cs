using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            Console.WriteLine("hello, what would you like? Press A, D, S, and L for any commands, and X to Exit");
            string bookToAdd, bookToDelete;

            List<string> bookList = new List<string> { "book 1", "book 2", "book 3" };

            char command = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                switch (command)
                {
                    
                    case 'A':
                        Console.WriteLine("type the name you want to add: ");
                        bookToAdd = Console.ReadLine();
                        bookList.Add(bookToAdd);
                        break;

                    case 'D':
                        Console.WriteLine("type the name you want to delete: ");
                        bookToDelete = Console.ReadLine();
                        bookList.Remove(bookToDelete);
                        break;

                    case 'S':
                        bookList.Sort;
                        break;

                    case 'L':
                       for(int i = 0; i < bookList.Count; i ++)
                        {
                            Console.WriteLine(bookList[i]);
                        }
                        break;
                }

            }
        }
    }
}
