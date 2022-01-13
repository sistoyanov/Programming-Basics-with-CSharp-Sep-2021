using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int numPupil = int.Parse(Console.ReadLine());
            int numDays = int.Parse(Console.ReadLine());

            //priceses and sport
            double totalPrice = 0;
            double pricePerDay = 0;
            string sport = "";
            switch (season)
            {
                case "Winter":
                    switch (group)
                    {
                        case "boys":
                            sport = "Judo";
                            pricePerDay = 9.60;
                            break;
                        case "girls":
                            sport = "Gymnastics";
                            pricePerDay = 9.60;
                            break;
                        case "mixed":
                            sport = "Ski";
                            pricePerDay = 10;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Spring":
                    switch (group)
                    {
                        case "boys":
                            sport = "Tennis";
                            pricePerDay = 7.20;
                            break;
                        case "girls":
                            sport = "Athletics";
                            pricePerDay = 7.20;
                            break;
                        case "mixed":
                            sport = "Cycling";
                            pricePerDay = 9.50;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Summer":
                    switch (group)
                    {
                        case "boys":
                            sport = "Football";
                            pricePerDay = 15;
                            break;
                        case "girls":
                            sport = "Volleyball";
                            pricePerDay = 15;
                            break;
                        case "mixed":
                            sport = "Swimming";
                            pricePerDay = 20;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            totalPrice = numDays * pricePerDay * numPupil;

            //discounts
            if (numPupil >= 50)
            {
                totalPrice *= 0.50;
            }
            else if (numPupil >= 20)
            {
                totalPrice *= 0.85;
            }
            else if (numPupil >= 10)
            {
                totalPrice *= 0.95;
            }

            //output
            Console.WriteLine($"{sport} {totalPrice:f2} lv.");




        }
    }
}
