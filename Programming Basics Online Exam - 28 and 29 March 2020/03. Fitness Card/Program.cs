using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Сумата, с която разполагаме - реално число в интервала[10.00…1000.00]
            //•	Пол - символ('m' за мъж и 'f' за жена)
            //•	Възраст - цяло число в интервала[5…105]
            //•	Спорт - текст(една от възможностите в таблицата)

            double budget = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double price = 0;

            switch (sport)
            {
                case "Gym":
                    switch (gender)
                    {
                        case "m":
                            price = 42;
                            break;
                        case "f":
                            price = 35;
                            break;
                    }
                    break;
                case "Boxing":
                    switch (gender)
                    {
                        case "m":
                            price = 41;
                            break;
                        case "f":
                            price = 37;
                            break;
                    }
                    break;
                case "Yoga":
                    switch (gender)
                    {
                        case "m":
                            price = 45;
                            break;
                        case "f":
                            price = 42;
                            break;
                    }
                    break;
                case "Zumba":
                    switch (gender)
                    {
                        case "m":
                            price = 34;
                            break;
                        case "f":
                            price = 31;
                            break;
                    }
                    break;
                case "Dances":
                    switch (gender)
                    {
                        case "m":
                            price = 51;
                            break;
                        case "f":
                            price = 53;
                            break;
                    }
                    break;
                case "Pilates":
                    switch (gender)
                    {
                        case "m":
                            price = 39;
                            break;
                        case "f":
                            price = 37;
                            break;
                    }
                    break;
            }

            if (age <= 19)
            {
                price *= 0.80;
            }
            
            Console.WriteLine(price <= budget ? $"You purchased a 1 month pass for {sport}." : $"You don't have enough money! You need ${price - budget:f2} more.");

        }
    }
}
