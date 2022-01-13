using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {

            int numDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double prise = 0;

            switch (place)
            {
                case "Bulgaria":
                    prise = points * numDancers;
                    switch (season)
                    {
                        case "summer":
                            prise *= 0.95;
                            break;
                        case "winter":
                            prise *= 0.92;
                            break;
                    }
                    break;
                case "Abroad":
                    prise = points * numDancers;
                    prise *= 1.50;
                    switch (season)
                    {
                        case "summer":
                            prise *= 0.90;
                            break;
                        case "winter":
                            prise *= 0.85;
                            break;
                    }
                    break;
            }

            double filnalPrise = prise * 0.25;
            double charity = prise * 0.75;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {filnalPrise / numDancers:f2}");
        }
    }
}
