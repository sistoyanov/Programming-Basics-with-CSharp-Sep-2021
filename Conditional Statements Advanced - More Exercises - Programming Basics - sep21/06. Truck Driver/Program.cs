using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());

            //body
            double pricePerKilometer = 0;
            if (kilometers <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKilometer = 0.75;
                        break;
                    case "Summer":
                        pricePerKilometer = 0.90;
                        break;
                    case "Winter":
                        pricePerKilometer = 1.05;
                        break;
                    default:
                        break;
                }
            }
            else if (kilometers <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKilometer = 0.95;
                        break;
                    case "Summer":
                        pricePerKilometer = 1.10;
                        break;
                    case "Winter":
                        pricePerKilometer = 1.25;
                        break;
                    default:
                        break;
                }
            }
            else if (kilometers <= 20000)
            {
                pricePerKilometer = 1.45;
            }

            //ouput
            double totalPriceForKilometers = kilometers * pricePerKilometer;
            double totalPriceForSeason = totalPriceForKilometers * 4;
            double salary = totalPriceForSeason * 0.90;
            Console.WriteLine($"{salary:f2}");
        }
    }
}
