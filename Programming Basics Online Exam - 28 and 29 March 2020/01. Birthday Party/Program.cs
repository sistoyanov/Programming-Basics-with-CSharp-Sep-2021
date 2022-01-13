using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double priceOfCake = rent * 0.20;
            double priceOfDrink = priceOfCake * 0.55;
            double priceOfAnimation = rent / 3;

            double totalPrice = rent + priceOfCake + priceOfDrink + priceOfAnimation;

            Console.WriteLine($"{totalPrice:f1}");
        }
    }
}
