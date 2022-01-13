using System;

namespace _08._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;

            switch (month)
            {
                case "May":
                case "October": priceStudio = 50;
                                priceApartment = 65;
                    break;
                case "June":
                case "September": priceStudio = 75.20;
                                  priceApartment = 68.70;
                    break;
                case "July":
                case "August": priceStudio = 76;
                               priceApartment = 77;
                    break;
                default: Console.WriteLine("Wrong input for month");
                    break;
            }
            if (days > 7 && days <= 14)
            {
                if (month == "May" || month == "October")
                {
                    priceStudio *= 0.95;
                }
            }
            else if (days > 14)
            {
                
                if (month == "May" || month == "October")
                {
                    priceStudio *= 0.7;
                }
                else if (month == "June" || month == "September")
                {
                    priceStudio *= 0.8;
                }

                priceApartment *= 0.9;
            }

            Console.WriteLine($"Apartment: {(days * priceApartment):f2} lv.");
            Console.WriteLine($"Studio: {(days * priceStudio):f2} lv.");
        }
    }
}
