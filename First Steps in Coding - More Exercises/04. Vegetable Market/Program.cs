using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegitablesPrice = double.Parse(Console.ReadLine());
            double frutsPrice = double.Parse(Console.ReadLine());
            double vegitablesWiegth = double.Parse(Console.ReadLine());
            double frutsWeigth = double.Parse(Console.ReadLine());

            double totalPrice = vegitablesPrice * vegitablesWiegth + frutsPrice * frutsWeigth;
            Console.WriteLine($"{totalPrice / 1.94:f2}");
        }
    }
}
