using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());
            double totalFood = double.Parse(Console.ReadLine());

            double totalDogFood = 0;
            double totalCatFood = 0;
            double totalBiskets = 0;

            for (int day = 1; day <= totalDays; day++)
            {
                
                double dogFood = double.Parse(Console.ReadLine());
                double catFood = double.Parse(Console.ReadLine());


                if (day % 3 == 0)
                {
                    double biskets = (dogFood + catFood) * 0.10;
                    totalBiskets += biskets;
                }
                
                totalDogFood += dogFood;
                totalCatFood += catFood;
            }

            double totalFoodEaten = totalDogFood + totalCatFood;


            Console.WriteLine($"Total eaten biscuits: {Math.Round(totalBiskets)}gr.");
            Console.WriteLine($"{totalFoodEaten / totalFood * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{totalDogFood / totalFoodEaten * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{totalCatFood / totalFoodEaten * 100:f2}% eaten from the cat.");
        }
    }
}
