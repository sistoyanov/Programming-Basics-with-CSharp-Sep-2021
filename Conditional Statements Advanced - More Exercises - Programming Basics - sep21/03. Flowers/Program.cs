using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int numChrysanthemums = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            //priceses
            double priceChrysanthemums = 0;
            double priceRoses = 0;
            double priceTulips = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    priceChrysanthemums = 2;
                    priceRoses = 4.10;
                    priceTulips = 2.50;
                    if (holiday == "Y")
                    {
                        priceChrysanthemums *= 1.15;
                        priceRoses *= 1.15;
                        priceTulips *= 1.15;
                    }
                    break;
                case "Autumn":
                case "Winter":
                    priceChrysanthemums = 3.75;
                    priceRoses = 4.50;
                    priceTulips = 4.15;
                    if (holiday == "Y")
                    {
                        priceChrysanthemums *= 1.15;
                        priceRoses *= 1.15;
                        priceTulips *= 1.15;
                    }
                    break;
                default:
                    break;
            }
            //body
            double totalPriceChrysanthemums = numChrysanthemums * priceChrysanthemums; 
            double totalPriceRoses = numRoses * priceRoses;                            
            double totalPriceTulips = numTulips * priceTulips;                         
            double totalPrice = totalPriceChrysanthemums + totalPriceRoses + totalPriceTulips;
            if (numTulips > 7 && season == "Spring")
            {
                totalPrice *= 0.95;
            }
            if (numRoses >= 10 && season == "Winter")
            {
                totalPrice *= 0.90;
            }
            if (numChrysanthemums + numRoses + numTulips > 20)
            {
                totalPrice *= 0.80;
            }
            totalPrice += 2;

            //output
            Console.WriteLine($"{totalPrice:f2}");
            


        }
    }
}
