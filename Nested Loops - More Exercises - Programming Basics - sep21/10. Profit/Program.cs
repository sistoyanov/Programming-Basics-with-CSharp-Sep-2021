using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCoinsOf1 = int.Parse(Console.ReadLine());
            int totalCoinsOf2 = int.Parse(Console.ReadLine());
            int totalBanknoteOf5 = int.Parse(Console.ReadLine());
            int totalSum = int.Parse(Console.ReadLine());

            for (int coinsOf1 = 0; coinsOf1 <= totalCoinsOf1; coinsOf1++)
            {
                for (int coinsOf2 = 0; coinsOf2 <= totalCoinsOf2; coinsOf2++)
                {
                    for (int banknoteOf5 = 0; banknoteOf5 <= totalBanknoteOf5; banknoteOf5++)
                    {
                        if ((coinsOf1 * 1) + (coinsOf2 * 2) + (banknoteOf5 * 5) == totalSum)
                        {
                            Console.WriteLine($"{coinsOf1} * 1 lv. + {coinsOf2} * 2 lv. + {banknoteOf5} * 5 lv. = {totalSum} lv.");
                        }
                    }
                }
            }

        }   
    }
}
