using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {

            int foodWeightKilos = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int foodWeightGrams = foodWeightKilos * 1000;
            int totalFoodEaten = 0;

            while (input != "Adopted")
            {
                int currentFoodEaten = int.Parse(input);
                totalFoodEaten += currentFoodEaten;
                input = Console.ReadLine();
            }

            Console.WriteLine(foodWeightGrams >= totalFoodEaten ? $"Food is enough! Leftovers: {foodWeightGrams - totalFoodEaten} grams." : $"Food is not enough. You need {totalFoodEaten - foodWeightGrams} grams more." );

        }
    }
}
