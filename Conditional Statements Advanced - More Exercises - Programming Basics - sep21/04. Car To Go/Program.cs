using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //body
            double price = 0;
            string type  = "";
            string car = "";

            switch (season)
            {
                case "Summer":
                    if (budget <= 100)
                    {
                        type = "Economy class";
                        car = "Cabrio";
                        price = budget * 0.35;
                    }
                    else if (budget <= 500)
                    {
                        type = "Compact class";
                        car = "Cabrio";
                        price = budget * 0.45;
                    }
                    else
                    {
                        type = "Luxury class";
                        car = "Jeep";
                        price = budget * 0.90;
                    }
                    break;
                case "Winter":
                    if (budget <= 100)
                    {
                        type = "Economy class";
                        car = "Jeep";
                        price = budget * 0.65;
                    }
                    else if (budget <= 500)
                    {
                        type = "Compact class";
                        car = "Jeep";
                        price = budget * 0.80;
                    }
                    else
                    {
                        type = "Luxury class";
                        car = "Jeep";
                        price = budget * 0.90;
                    }
                    break;
                default:
                    break;
            }

            //ouput
            Console.WriteLine($"{type}");
            Console.WriteLine($"{car} - {price:f2}");


        }
    }
}
