using System;

namespace _02._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double sum = 0;

            if (rows != 0 || colums != 0)
            {
                switch (type)
                {
                    case "Premiere": sum = (rows * colums) * 12;break;
                    case "Normal": sum = (rows * colums) * 7.5;break;
                    case "Discount": sum = (rows * colums) * 5;break;
                    default: Console.WriteLine("Wrong type"); break;
                }
                Console.WriteLine($"{sum:f2} leva");
            }
            else
            {
                Console.WriteLine("No reservations");
            }
        }
    }
}
