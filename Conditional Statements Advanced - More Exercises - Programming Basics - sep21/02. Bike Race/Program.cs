using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int numJunior = int.Parse(Console.ReadLine());
            int numSenior = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();

            //priceses
            double juniorPrice = 0;
            double seniorPrice = 0;
            switch (trace)
            {
                case "trail":
                    juniorPrice = 5.50;
                    seniorPrice = 7;
                    break;
                case "cross-country":
                    juniorPrice = 8;
                    seniorPrice = 9.50;
                    if (numJunior + numSenior >= 50)
                    {
                        juniorPrice = 8 * 0.75;
                        seniorPrice = 9.50 * 0.75;
                    }
                    break;
                case "downhill":
                    juniorPrice = 12.25;
                    seniorPrice = 13.75;
                    break;
                case "road":
                    juniorPrice = 20;
                    seniorPrice = 21.50;
                    break;
                default:
                    break;
            }
            //output
            double totalJuniorMoney = numJunior * juniorPrice;
            double totalSeniorMoney = numSenior * seniorPrice;
            double totalMoney = (totalJuniorMoney + totalSeniorMoney) * 0.95;
            Console.WriteLine($"{totalMoney:f2}");

        }
    }
}
