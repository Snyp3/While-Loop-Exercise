using System;

namespace P01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookName = Console.ReadLine();
            int count = 0;

            string input = string.Empty;

            while (input!= "No More Books")
            {
                input = Console.ReadLine();
                
                if (input == bookName)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }

                if (input != "No More Books")
                {
                    count++;
                }
                if (input == "No More Books")
                {
                    //o	"The book you search is not here!"
                    //o   "You checked {брой} books."
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {count} books.");
                }

            }
        }
    }
}
