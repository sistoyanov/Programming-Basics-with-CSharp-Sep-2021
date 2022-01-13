using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFrames = int.Parse(Console.ReadLine());
            string typeOfFrame = Console.ReadLine();
            string delivery = Console.ReadLine();

            double priceOfFrame = 0;
            double totalPrice = 0;
            
            switch (typeOfFrame)
            {
                case "90X130":
                    priceOfFrame = 110;
                    if (numFrames > 60)
                    {
                        priceOfFrame *= 0.92;
                    }
                    else if (numFrames > 30)
                    {
                        priceOfFrame *= 0.95;
                    }
                    break;
                case "100X150":
                    priceOfFrame = 140;
                    if (numFrames > 80)
                    {
                        priceOfFrame *= 0.90;
                    }
                    else if (numFrames > 40)
                    {
                        priceOfFrame *= 0.94;
                    }
                    break;
                case "130X180":
                    priceOfFrame = 190;
                    if (numFrames > 50)
                    {
                        priceOfFrame *= 0.88;
                    }
                    else if (numFrames > 20)
                    {
                        priceOfFrame *= 0.93;
                    }
                    break;
                case "200X300":
                    priceOfFrame = 250;
                    if (numFrames > 50)
                    {
                        priceOfFrame *= 0.86;
                    }
                    else if (numFrames > 25)
                    {
                        priceOfFrame *= 0.91;
                    }
                    break;
                default:
                    break;
            }

            totalPrice = numFrames * priceOfFrame;

            if (delivery == "With delivery")
            {
                totalPrice += 60;
            }

            if (numFrames > 99)
            {
                totalPrice *= 0.96;
            }

            Console.WriteLine(numFrames > 10 ? $"{totalPrice:f2} BGN" : "Invalid order");
        }
    }
}
