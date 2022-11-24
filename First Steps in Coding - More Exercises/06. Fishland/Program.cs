using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double priceMackerel = double.Parse(Console.ReadLine());
            double priceSprat = double.Parse(Console.ReadLine());
            double weightBonito = double.Parse(Console.ReadLine());
            double weigthScad = double.Parse(Console.ReadLine());
            double weigthMussels = double.Parse(Console.ReadLine());

            //priceses
            double priceBonito = priceMackerel + (priceMackerel* 0.60);
            double priceScad = priceSprat + (priceSprat* 0.80);
            double priceMussels = 7.50;

            //output
            Console.WriteLine($"{(priceBonito * weightBonito) + (priceScad * weigthScad) + (priceMussels * weigthMussels):f2}");
        }
    }
}
