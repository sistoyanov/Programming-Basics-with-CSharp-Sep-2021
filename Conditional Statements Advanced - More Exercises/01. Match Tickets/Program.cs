using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //iput

            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            //priceses
            const double VIP_TICKET = 499.99;
            const double TICKET = 249.99;

            //body
            double tiketsTotalPrice = 0;
            double transportPrice = 0;
            if (people >= 50)
            {
                transportPrice = budget * 0.25;
                if (category == "VIP")
                {
                    tiketsTotalPrice = VIP_TICKET * people;
                }
                else if (category == "Normal")
                {
                    tiketsTotalPrice = TICKET * people;
                }
            }
            else if (people >= 25)
            {
                transportPrice = budget * 0.40;
                if (category == "VIP")
                {
                    tiketsTotalPrice = VIP_TICKET * people;
                }
                else if (category == "Normal")
                {
                    tiketsTotalPrice = TICKET * people;
                }
            }
            else if (people >= 10)
            {
                transportPrice = budget * 0.50;
                if (category == "VIP")
                {
                    tiketsTotalPrice = VIP_TICKET * people;
                }
                else if (category == "Normal")
                {
                    tiketsTotalPrice = TICKET * people;
                }
            }
            else if (people >= 5)
            {
                transportPrice = budget * 0.60;
                if (category == "VIP")
                {
                    tiketsTotalPrice = VIP_TICKET * people;
                }
                else if (category == "Normal")
                {
                    tiketsTotalPrice = TICKET * people;
                }
            }
            else
            {
                transportPrice = budget * 0.75;
                if (category == "VIP")
                {
                    tiketsTotalPrice = VIP_TICKET * people;
                }
                else if (category == "Normal")
                {
                    tiketsTotalPrice = TICKET * people;
                }
            }

            //ouput
            double totalPrice = transportPrice + tiketsTotalPrice;
            Console.WriteLine(budget >= totalPrice ? ($"Yes! You have {budget - totalPrice:f2} leva left.") : ($"Not enough money! You need {totalPrice - budget:f2} leva."));

        }
    }
}
