using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceBagageOver20 = double.Parse(Console.ReadLine());
            double weithOfBagage = double.Parse(Console.ReadLine());
            int daysToTrip = int.Parse(Console.ReadLine());
            int bagageNum = int.Parse(Console.ReadLine());

            double priceOfBagage = 0;
            double totalPrice = 0;

            if (weithOfBagage < 10)
            {
                priceOfBagage = priceBagageOver20 * 0.20;
            }
            else if (weithOfBagage <= 20)
            {
                priceOfBagage = priceBagageOver20 * 0.50;
            }
            else
            {
                priceOfBagage = priceBagageOver20;
            }

            if (daysToTrip > 30)
            {
                priceOfBagage *= 1.10;
            }
            else if (daysToTrip >= 7)
            {
                priceOfBagage *= 1.15;
            }
            else
            {
                priceOfBagage *= 1.40;
            }

            totalPrice = priceOfBagage * bagageNum;

            Console.WriteLine($"The total price of bags is: {totalPrice:f2} lv.");
        }
    }
}
