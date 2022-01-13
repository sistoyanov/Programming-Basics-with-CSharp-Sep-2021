using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double sum = 0;
           
            while (money != "NoMoreMoney")
            {
                double currentMoney = double.Parse(money);
                if ( currentMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += currentMoney;
                Console.WriteLine($"Increase: {currentMoney:f2}");
                money = Console.ReadLine();
            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
