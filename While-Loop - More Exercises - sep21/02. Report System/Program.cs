using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededMoney = int.Parse(Console.ReadLine());
            int sumMoney = 0;
            int transactionCounter = 0;
            int cardPaymetsCounter = 0;
            int cashPaymetsCopunter = 0;
            int sumCardPaymetsMoney = 0;
            int sumCashPaymetsMoney = 0;

            while (sumMoney < neededMoney)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                int currentMoney = int.Parse(input);
                transactionCounter ++;

                if (transactionCounter % 2 == 0)
                {
                    if (currentMoney < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cardPaymetsCounter++;
                        sumMoney += currentMoney;
                        sumCardPaymetsMoney += currentMoney;
                    }
                    
                }
                else
                {
                    if (currentMoney > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cashPaymetsCopunter++;
                        sumMoney += currentMoney;
                        sumCashPaymetsMoney += currentMoney;
                    }
                }

                
            }

            double avarageCashPayments = (double)sumCashPaymetsMoney / cashPaymetsCopunter;
            double avarageCardPayments = (double)sumCardPaymetsMoney / cashPaymetsCopunter;

            if (sumMoney < neededMoney)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else
            {
                Console.WriteLine($"Average CS: {avarageCashPayments:f2}");
                Console.WriteLine($"Average CC: {avarageCardPayments:f2}");
            }
        }
    }
}
