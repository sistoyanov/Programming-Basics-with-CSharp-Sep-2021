using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());

            if (fuel == "Diesel")
            {
                Console.WriteLine(liters >= 25 ? ($"You have enough {fuel.ToLower()}.") : ($"Fill your tank with {fuel.ToLower()}!"));
            }
            else if (fuel == "Gasoline")
            {
                Console.WriteLine(liters >= 25 ? ($"You have enough {fuel.ToLower()}.") : ($"Fill your tank with {fuel.ToLower()}!"));
            }
            else if (fuel == "Gas")
            {
                Console.WriteLine(liters >= 25 ? ($"You have enough {fuel.ToLower()}.") : ($"Fill your tank with {fuel.ToLower()}!"));
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
