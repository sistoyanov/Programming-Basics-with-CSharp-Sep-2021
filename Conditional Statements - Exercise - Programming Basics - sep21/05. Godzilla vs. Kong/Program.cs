using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Godzilla_vs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            int peopole = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            //Calculations
            double decor = budget * 0.10;
            double clothesPrice = peopole * price;
            if (peopole > 150)
            {
                clothesPrice -= clothesPrice * 0.10;
            }
            double outcomes = clothesPrice + decor;

            //Output
            if (outcomes > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {outcomes - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - outcomes:f2} leva left.");
            }
        }
    }
}
