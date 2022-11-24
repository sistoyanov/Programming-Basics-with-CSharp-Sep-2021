using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingmashine = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());
            double money = 0;
            double savedMoney = 0;
            int toysCount = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    savedMoney += money;
                    savedMoney -= 1;
                }
                else
                {
                    toysCount ++;
                }
            }
            savedMoney += toysCount * priceToy;
            Console.WriteLine(savedMoney >= priceWashingmashine ? $"Yes! {savedMoney - priceWashingmashine:f2}" : $"No! {priceWashingmashine - savedMoney:f2}");

        }
    }
}
