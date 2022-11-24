using System;

namespace _10._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string feedback = Console.ReadLine();
            double price = 0;

            if (days < 10 && days > 0)
            {
                switch (room)
                {
                    case "room for one person": price = (days - 1) * 18;break;
                    case "apartment": price = ((days - 1) * 25) * 0.7;break;
                    case "president apartment": price = ((days - 1) * 35) * 0.9;break;
                    default: Console.WriteLine("Wrong input for room"); break;
                }

            }
            else if (days >= 10 && days <= 15)
            {
                switch (room)
                {
                    case "room for one person": price = (days - 1) * 18; break;
                    case "apartment": price = ((days - 1) * 25) * 0.65; break;
                    case "president apartment": price = ((days - 1) * 35) * 0.85; break;
                    default: Console.WriteLine("Wrong input for room"); break;
                }
            }
            else if (days > 15)
            {
                switch (room)
                {
                    case "room for one person": price = (days - 1) * 18; break;
                    case "apartment": price = ((days - 1) * 25) * 0.5; break;
                    case "president apartment": price = ((days - 1) * 35) * 0.8; break;
                    default: Console.WriteLine("Wrong input for room"); break;
                }
            }
            else
            {
                Console.WriteLine("Wrong input for days");
            }

            if (feedback == "positive")
            {
                price *= 1.25;
                Console.WriteLine($"{price:f2}");  
            }
            else if (feedback == "negative")
            {
                price *= 0.9;
                Console.WriteLine($"{price:f2}");
            }
            else
            {
                Console.WriteLine("Wrong input for feedback");
            }
        }
    }
}
