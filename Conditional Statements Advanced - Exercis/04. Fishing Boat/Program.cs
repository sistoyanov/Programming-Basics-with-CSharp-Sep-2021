using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            //body
            double price = 0;
            
            if (fishers <= 6)
            {
                switch (season)
                {
                    case "Spring":
                        price = 3000 * 0.90;
                         break;
                    case "Summer":
                    case "Autumn":
                        price = 4200 * 0.90;
                        break;
                    case "Winter":
                        price = 2600 * 0.90;
                        break;
                }
            }
            else if (fishers <= 11)
            {

                switch (season)
                {
                    case "Spring":
                        price = 3000 * 0.85;
                        break;
                    case "Summer":
                    case "Autumn":
                        price = 4200 * 0.85;
                        break;
                    case "Winter":
                        price = 2600 * 0.85;
                        break;
                }
            }
            else if (fishers > 11)
            {
                switch (season)
                {
                    case "Spring":
                        price = 3000 * 0.75;
                        break;
                    case "Summer":
                    case "Autumn":
                        price = 4200 * 0.75;
                        break;
                    case "Winter":
                        price = 2600 * 0.75;
                        break;
                }
            }

            if (fishers % 2 == 0 && season != "Autumn")
            {
                price *= 0.95;
            }

            double money = Math.Abs(budget - price);

            //output
            Console.WriteLine(budget >= price ? ($"Yes! You have {money:f2} leva left.") : ($"Not enough money! You need {money:f2} leva."));

        }
    }
}
