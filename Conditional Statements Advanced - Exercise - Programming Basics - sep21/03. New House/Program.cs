using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string flowers = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            //body
            double price = 0;

            switch (flowers)
            {
                case "Roses":
                    price = 5;
                    if (numFlowers > 80)
                    {
                        price *= 0.90;
                    }
                break;
                case "Dahlias":
                    price = 3.80;
                    if (numFlowers > 90)
                    {
                        price *= 0.85;
                    }
                break;
                case "Tulips":
                    price = 2.80;
                    if (numFlowers > 80)
                    {
                        price *= 0.85;
                    }
                break;
                case "Narcissus":
                    price = 3;
                    if (numFlowers < 120)
                    {
                        price *= 1.15;
                    }
                break;
                case "Gladiolus":
                    price = 2.50;
                    if (numFlowers < 80)
                    {
                        price *= 1.20;
                    }
                break;
            }

            double totalPrice = numFlowers * price;
            double money = Math.Abs(budget - totalPrice);

            //output
            Console.WriteLine(budget >= totalPrice ? ($"Hey, you have a great garden with {numFlowers} {flowers} and {money:f2} leva left.") : ($"Not enough money, you need {money:f2} leva more."));
        }
    }
}
