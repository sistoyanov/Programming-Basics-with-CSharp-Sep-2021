using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numNormalTicket = int.Parse(Console.ReadLine());
            int numKidsTicket = int.Parse(Console.ReadLine());
            double priceNormalTicket = double.Parse(Console.ReadLine());
            double taxPrice = double.Parse(Console.ReadLine());

            double priceKidTicket = (priceNormalTicket * 0.30) + taxPrice;
            priceNormalTicket += taxPrice;

            double totalPrice = (numNormalTicket * priceNormalTicket) + (numKidsTicket * priceKidTicket);
            double profit = totalPrice * 0.20;

            Console.WriteLine($"The profit of your agency from {name} tickets is {profit:f2} lv.");
        }
    }
}
