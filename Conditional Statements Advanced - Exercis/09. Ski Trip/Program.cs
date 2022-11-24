using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            //input 
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();

            double priceRoom = 18;
            double priceApartment = 25;
            double pricePresidentApartment = 35;

            //body
            days -= 1;
            double price = 0;
            if (days < 10)
            {
                if (room == "apartment")
                {
                    price = priceApartment * days * 0.70;
                }
                else if (room == "president apartment")
                {
                    price = pricePresidentApartment * days * 0.90;
                }
                else
                {
                    price = priceRoom * days;
                }
            }
            else if (days < 16)
            {
                if (room == "apartment")
                {
                    price = priceApartment * days * 0.65;
                }
                else if (room == "president apartment")
                {
                    price = pricePresidentApartment * days * 0.85;
                }
                else
                {
                    price = priceRoom * days;
                }
            }
            else if (days > 15)
            {
                if (room == "apartment")
                {
                    price = priceApartment * days * 0.50;
                }
                else if (room == "president apartment")
                {
                    price = pricePresidentApartment * days * 0.80;
                }
                else
                {
                    price = priceRoom * days;
                }
            }

            if (feedback == "positive")
            {
                Console.WriteLine($"{price +=  price * 0.25:f2}");
            }
            else
            {
                Console.WriteLine($"{price -= price * 0.10:f2}");
            }
        }
    }
}
