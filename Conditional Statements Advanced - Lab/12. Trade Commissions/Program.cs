using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double commision = 0;

            if (quantity > -1 && quantity <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = 0.05;
                        break;
                    case "Varna":
                        commision = 0.045;
                        break;
                    case "Plovdiv":
                        commision = 0.055;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (quantity > 500 && quantity <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = 0.07;
                        break;
                    case "Varna":
                        commision = 0.075;
                        break;
                    case "Plovdiv":
                        commision = 0.08;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (quantity > 1000 && quantity <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = 0.08;
                        break;
                    case "Varna":
                        commision = 0.10;
                        break;
                    case "Plovdiv":
                        commision = 0.12;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (quantity > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = 0.12;
                        break;
                    case "Varna":
                        commision = 0.13;
                        break;
                    case "Plovdiv":
                        commision = 0.145;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine(commision > 0 ? ($"{quantity * commision:f2}") : "");

        }
    }
}
