using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesPerDay = int.Parse(Console.ReadLine());
            int numOfWalksPerDay = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            int burrnedCalories = minutesPerDay * numOfWalksPerDay * 5;
            int neededCalories = caloriesPerDay / 2;

            if (burrnedCalories >= neededCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burrnedCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burrnedCalories}.");
            }
        }
    }
}
