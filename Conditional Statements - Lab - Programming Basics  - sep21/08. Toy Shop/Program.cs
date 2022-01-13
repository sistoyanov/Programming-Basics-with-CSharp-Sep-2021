using System;

namespace _08._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double price = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //prices
            double puzzelPrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            //calculations
            double puzzelsTotalPrice = puzzels * puzzelPrice;
            double dollsTotalPrice = dolls * dollPrice;
            double bearsTotalPrice = bears * bearPrice;
            double minionsTotalPrice = minions * minionPrice;
            double trucksTotalprice = trucks * truckPrice; 
            int toys = puzzels + dolls + bears + minions + trucks;
            double totalPrice = puzzelsTotalPrice + dollsTotalPrice + bearsTotalPrice + minionsTotalPrice + trucksTotalprice;
            double revenueAfterRent = totalPrice - (totalPrice * 0.10);
           
            //ouput
            double revenue;
            
            if (toys >= 50)
            {
                revenue = revenueAfterRent - (revenueAfterRent * 0.250);
            }
            else
                revenue = revenueAfterRent;
            
            if (price <= revenue)
            {
                Console.WriteLine($"Yes! {revenue - price :f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {price - revenue :f2} lv needed.");
            }

        }
    }
}
