using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            string currentPass = Console.ReadLine();
            while (currentPass != password)
            {
                currentPass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
