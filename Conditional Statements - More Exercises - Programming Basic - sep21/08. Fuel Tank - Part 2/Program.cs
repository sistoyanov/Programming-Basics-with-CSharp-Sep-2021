using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            //priceses

            double gasolinePrice = 2.22;
            double diselPrice = 2.33;
            double gasPrice = 0.93;

            if (clubCard == "Yes")
            {
                gasolinePrice -= 0.18;
                diselPrice -= 0.12;
                gasPrice -= 0.08;
            }

            //body
            double price = 0;
            switch (fuelType)
            {
                case "Gasoline":
                    if (fuelQuantity > 25)
                    {
                        price = gasolinePrice * fuelQuantity;
                        price *= 0.90;
                    }
                    else if (fuelQuantity >= 20)
                    {
                        price = gasolinePrice * fuelQuantity;
                        price *= 0.92;
                    }
                    else
                    {
                        price = gasolinePrice * fuelQuantity;
                    }
                    Console.WriteLine($"{price:f2} lv.");
                    break;
                case "Diesel":
                    if (fuelQuantity > 25)
                    {
                        price = diselPrice * fuelQuantity;
                        price *= 0.90;
                    }
                    else if (fuelQuantity >= 20)
                    {
                        price = diselPrice * fuelQuantity;
                        price *= 0.92;
                    }
                    else
                    {
                        price = diselPrice * fuelQuantity;
                    }
                    Console.WriteLine($"{price:f2} lv.");
                    break;
                case "Gas":
                    if (fuelQuantity > 25)
                    {
                        price = gasPrice * fuelQuantity;
                        price *= 0.90;
                    }
                    else if (fuelQuantity >= 20)
                    {
                        price = gasPrice * fuelQuantity;
                        price *= 0.92;
                    }
                    else
                    {
                        price = gasPrice * fuelQuantity;
                    }
                    Console.WriteLine($"{price:f2} lv.");
                    break;
                default:
                    break;
            }


        }
    }
}
