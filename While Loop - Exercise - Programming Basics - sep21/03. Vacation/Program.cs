using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());
            int days = 0;
            int daysSpending = 0;

            while (neededMoney > savedMoney)
            {
                days++;
                string action = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());

                if (action == "spend")
                {
                    daysSpending++;
                    if (daysSpending == 5)
                    {
                        break;
                    }
                    
                    savedMoney -= currentMoney;
                    
                    if (savedMoney < 0)
                    {
                        savedMoney = 0;
                    }
                }
                else if (action == "save")
                {
                    savedMoney += currentMoney;
                    daysSpending = 0;
                }
            }

            if (daysSpending == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
