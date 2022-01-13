using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            // input

            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            //body
            double totalDogFood = days * dogFood;
            double totalCatFood = days * catFood;
            double totalTurtleFood = (days * turtleFood) / 1000;
            double totalFood = totalDogFood + totalCatFood + totalTurtleFood;

            //output

            if (food >= totalFood)
            {
                Console.WriteLine($"{Math.Floor(food - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - food)} more kilos of food are needed.");
            }
        }
    }
}
