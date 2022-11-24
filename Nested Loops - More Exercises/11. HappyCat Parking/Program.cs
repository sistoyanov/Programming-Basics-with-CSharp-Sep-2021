using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());
            int hourPerDay = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            for (int day = 1; day <= totalDays; day++)
            {
                double pricePerDay = 0;

                for (int hour = 1; hour <= hourPerDay; hour++)
                {
                    
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        pricePerDay += 2.50;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        pricePerDay += 1.25;
                    }
                    else
                    {
                        pricePerDay += 1;
                    }
                }

                totalPrice += pricePerDay;
                Console.WriteLine($"Day: {day} - {pricePerDay:f2} leva");
            }

            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}
