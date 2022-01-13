using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            const double LOVE_MESSAGE = 0.60;
            const double WAX_ROSE = 7.20;
            const double KEY_HOLDER = 3.60;
            const double DRAFT = 18.20;
            const double SURPRICE = 22;

            double price = double.Parse(Console.ReadLine());
            int numLoveMessage = int.Parse(Console.ReadLine());
            int numWaxRose = int.Parse(Console.ReadLine());
            int numKeyHolder = int.Parse(Console.ReadLine());
            int numDraft = int.Parse(Console.ReadLine());
            int numSurprice = int.Parse(Console.ReadLine());

            int totalProducts = numLoveMessage + numWaxRose + numKeyHolder + numDraft + numSurprice;
            double profit = (numLoveMessage * LOVE_MESSAGE) + (numWaxRose * WAX_ROSE) + (numKeyHolder * KEY_HOLDER) + (numDraft * DRAFT) + (numSurprice * SURPRICE);

            if (totalProducts >= 25)
            {
                profit *= 0.65;
            }

            profit *= 0.90;

            if (profit >= price)
            {
                Console.WriteLine($"Yes! {profit - price:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {price - profit:f2} lv needed.");
            }
            
            
        }
    }
}
