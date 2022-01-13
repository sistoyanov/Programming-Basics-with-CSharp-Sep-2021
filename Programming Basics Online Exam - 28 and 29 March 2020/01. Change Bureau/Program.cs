using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            const double BITCOIN_PRICE = 1168;
            const double DOLLAR_PRICE = 1.76;
            const double EURO_PRICE = 1.95;

            double juanPrice = DOLLAR_PRICE * 0.15;

            double bitcoins = double.Parse(Console.ReadLine());
            double juans = double.Parse(Console.ReadLine());
            double commisionPercent = double.Parse(Console.ReadLine());

            double totalLeva = (juanPrice * juans) + (bitcoins * BITCOIN_PRICE);
            double totalEuro = totalLeva / EURO_PRICE;
            double commision = totalEuro * commisionPercent / 100;
            
            Console.WriteLine($"{totalEuro - commision:f2}");
        }
    }
}
