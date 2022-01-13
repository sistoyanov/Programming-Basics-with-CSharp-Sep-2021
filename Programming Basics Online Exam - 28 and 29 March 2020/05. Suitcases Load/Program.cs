using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalCapacity = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 0;

            while (input != "End")
            {
                double currentCapacity = double.Parse(input);
                counter++;
                if (counter % 3 == 0)
                {
                    currentCapacity *= 1.10;
                }
                if (currentCapacity >= totalCapacity)
                {
                    counter--;
                    break;
                }
                totalCapacity -= currentCapacity;
                input = Console.ReadLine();
            }

            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine("No more space!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
