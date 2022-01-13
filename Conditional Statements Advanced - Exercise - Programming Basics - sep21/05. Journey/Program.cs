using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //body
            string destination = "";
            string place = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    budget *= 0.30;
                }
                else
                {
                    place = "Hotel";
                    budget *= 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    budget *= 0.40;
                }
                else
                {
                    place = "Hotel";
                    budget *= 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                place = "Hotel";
                budget *= 0.90;
            }

            //output
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {budget:f2}");
            
        }
    }
}
