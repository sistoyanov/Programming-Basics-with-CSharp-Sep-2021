using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string currentBook = Console.ReadLine();
            int bookCounter = 0;

            while (currentBook != "No More Books")
            {
                if (currentBook == searchedBook)
                {
                    break;
                }
                bookCounter++;
                currentBook = Console.ReadLine();
            }

            if (currentBook == "No More Books")
            {

                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCounter} books.");
            }

            else
            {
                Console.WriteLine($"You checked {bookCounter} books and found it.");
            }
            
        }
    }
}