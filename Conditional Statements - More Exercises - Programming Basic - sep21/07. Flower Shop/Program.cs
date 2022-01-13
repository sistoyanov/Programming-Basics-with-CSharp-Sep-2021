using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            //prices
            const double MAGNOLIAS_PRICE = 3.25;
            const double HYACINTH_PRICE = 4;
            const double ROSES_PRICE = 3.50;
            const double CACTUSES_PRICE = 8;

            //body
            double totalMoney = (magnolias * MAGNOLIAS_PRICE) + (hyacinth * HYACINTH_PRICE) + (roses * ROSES_PRICE) + (cactuses * CACTUSES_PRICE);
            double profit = totalMoney * 0.95;

            //output
            Console.WriteLine(profit >= price ? ($"She is left with {Math.Floor(profit - price)} leva.") : ($"She will have to borrow {Math.Ceiling(price - profit)} leva."));

        }
    }
}
