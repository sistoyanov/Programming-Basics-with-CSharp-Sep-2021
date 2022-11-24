using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int kilometers = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            //body
            const double TAXI_STARTING_PRICE = 0.70;
            const double TAXI_DAY_PRICE = 0.79;
            const double TAXI_NIGHT_PRICE = 0.90;
            const double BUS_PRICE = 0.09;
            const double TRAIN_PRICE = 0.06;
            double totalPrice = 0;

            if (kilometers >= 100)
            {
                totalPrice = kilometers * TRAIN_PRICE;
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                totalPrice = kilometers * BUS_PRICE;
            }
            else
            {
                if (time == "day")
                {
                    totalPrice = TAXI_STARTING_PRICE + TAXI_DAY_PRICE * kilometers;
                }
                else
                {
                    totalPrice = TAXI_STARTING_PRICE + TAXI_NIGHT_PRICE * kilometers;
                }
            }
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
