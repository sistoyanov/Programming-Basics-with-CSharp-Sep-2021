using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BOTTLE = 750;
            const int DISH = 5;
            const int POT = 15;

            int washesCount = 0;
            int dishCount = 0;
            int potCount = 0;

            int numBottles = int.Parse(Console.ReadLine());
            int totalDetergent = numBottles * BOTTLE;

            while (totalDetergent >= 0)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                washesCount++;
                int numDishes = int.Parse(input);
                int usedDetergent;

                if (washesCount == 3)
                {
                    potCount += numDishes;
                    usedDetergent = numDishes * POT;
                    totalDetergent -= usedDetergent;
                    washesCount = 0;
                }
                else
                {
                    dishCount += numDishes;
                    usedDetergent = numDishes * DISH;
                    totalDetergent -= usedDetergent;
                }
            }

            if (totalDetergent >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishCount} dishes and {potCount} pots were washed.");
                Console.WriteLine($"Leftover detergent {totalDetergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(totalDetergent)} ml. more necessary!");
            }
        }
    }
}
