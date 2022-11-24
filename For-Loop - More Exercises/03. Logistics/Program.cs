using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BUS_PRICE = 200;
            const int TRUCK_PRICE = 175;
            const int TRAIN_PRICE = 120;

            int num = int.Parse(Console.ReadLine());

            int totalPrice = 0;
            int totalWeght = 0;
            int busCounter = 0;
            int truckCounter = 0;
            int trainCounter = 0;

            for (int i = 1; i <= num; i++)
            {
                int currentWeight = int.Parse(Console.ReadLine());

                if (currentWeight <= 3)
                {
                    totalPrice += currentWeight * BUS_PRICE;
                    totalWeght += currentWeight;
                    busCounter += currentWeight;
                }
                else if (currentWeight <= 11)
                {
                    totalPrice += currentWeight * TRUCK_PRICE;
                    totalWeght += currentWeight;
                    truckCounter += currentWeight;
                }
                else //(currentWeight >= 12)
                {
                    totalPrice += currentWeight * TRAIN_PRICE;
                    totalWeght += currentWeight;
                    trainCounter += currentWeight;
                }
            }

            double avaragePrice = (double)totalPrice / totalWeght;
            double avarageBusPercents = ((double)busCounter / totalWeght) * 100;
            double avarageTruckPercents = ((double)truckCounter / totalWeght) * 100;
            double avarageTrainPercents = ((double)trainCounter / totalWeght) * 100;
            Console.WriteLine($"{avaragePrice:f2}");
            Console.WriteLine($"{avarageBusPercents:f2}%");
            Console.WriteLine($"{avarageTruckPercents:f2}%");
            Console.WriteLine($"{avarageTrainPercents:f2}%");
        }
    }
}
