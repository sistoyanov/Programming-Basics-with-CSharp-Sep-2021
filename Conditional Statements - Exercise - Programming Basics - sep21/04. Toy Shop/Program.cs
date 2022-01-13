using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Priceses
            const double PUZZEL = 2.60;
            const double DOLL = 3;
            const double BEAR = 4.10;
            const double MINION = 8.20;
            const double TRUCK = 2;

            //Input
            double vacation = double.Parse(Console.ReadLine());
            int puzzelNum = int.Parse(Console.ReadLine());
            int dollNum = int.Parse(Console.ReadLine());
            int bearlNum = int.Parse(Console.ReadLine());
            int minionNum = int.Parse(Console.ReadLine());
            int trucklNum = int.Parse(Console.ReadLine());

            //Calculations
            int totalNum = puzzelNum + dollNum + bearlNum + minionNum + trucklNum;
            double totalPrice = (PUZZEL * puzzelNum) + (DOLL * dollNum) + (BEAR * bearlNum) + (MINION * minionNum) + (TRUCK * trucklNum);

            //Discount
            if (totalNum >= 50)
            {
                double dicount = totalPrice * 0.25;
                totalPrice -= dicount;
            }

            //Rent
            totalPrice -= totalPrice * 0.10;

            //Output
            if (totalPrice >= vacation)
            {
                Console.WriteLine($"Yes! {totalPrice - vacation :f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {vacation - totalPrice :f2} lv needed.");
            }
            
        }
    }
}
