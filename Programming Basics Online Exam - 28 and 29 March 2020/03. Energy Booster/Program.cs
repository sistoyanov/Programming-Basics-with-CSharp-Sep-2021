using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Плод - текст с възможности: "Watermelon", "Mango", "Pineapple" или "Raspberry"
            //2.Размерът на сета -текст с възможности: "small" или "big"
            //3.Брой на поръчаните сетове - цяло число в интервала[1 … 10000

            string frut = Console.ReadLine();
            string size = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            double price = 0;
            double totalPrice = 0;

            switch (frut)
            {
                case "Watermelon":
                    switch (size)
                    {
                        case "small":
                            price =  2 * 56;
                            break;
                        case "big":
                            price = 5 * 28.70;
                            break;
                    }
                    break;
                case "Mango":
                    switch (size)
                    {
                        case "small":
                            price = 2 * 36.66;
                            break;
                        case "big":
                            price = 5 * 19.60;
                            break;
                    }
                    break;
                case "Pineapple":
                    switch (size)
                    {
                        case "small":
                            price = 2 * 42.10;
                            break;
                        case "big":
                            price = 5 * 24.80;
                            break;
                    }
                    break;
                case "Raspberry":
                    switch (size)
                    {
                        case "small":
                            price = 2 * 20;
                            break;
                        case "big":
                            price = 5 * 15.20;
                            break;
                    }
                    break;

            }

            totalPrice = number * price;

            if (totalPrice > 1000)
            {
                totalPrice *= 0.50;
            }
            else if (totalPrice >= 400)
            {
                totalPrice *= 0.85;
            }
            
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
