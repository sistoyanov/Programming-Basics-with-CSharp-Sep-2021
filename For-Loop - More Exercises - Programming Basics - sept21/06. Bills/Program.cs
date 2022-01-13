using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            const double WATER_PRICE = 20;
            const double INTERNET_PRICE = 15;

            int period = int.Parse(Console.ReadLine());

            double totalBills = 0;
            double totalOtherBills = 0;
            double totalElectricityBills = 0;

            for (int i = 1; i <= period; i++)
            {
                double electricityPrice = double.Parse(Console.ReadLine());
                double allBils = WATER_PRICE + INTERNET_PRICE + electricityPrice;
                double otheBills = allBils * 1.20;

                totalElectricityBills += electricityPrice;
                totalOtherBills += otheBills;
                totalBills += allBils + otheBills;
            }

            Console.WriteLine($"Electricity: {totalElectricityBills:f2} lv");
            Console.WriteLine($"Water: {WATER_PRICE * period:f2} lv");
            Console.WriteLine($"Internet: {INTERNET_PRICE * period:f2} lv");
            Console.WriteLine($"Other: {totalOtherBills:f2} lv");
            Console.WriteLine($"Average: {totalBills / period:f2} lv");
        }
    }
}
