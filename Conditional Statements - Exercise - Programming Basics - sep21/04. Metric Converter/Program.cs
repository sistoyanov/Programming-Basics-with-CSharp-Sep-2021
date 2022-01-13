using System;

namespace _04._Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            string unit1 = Console.ReadLine();
            string unit2 = Console.ReadLine();

            if( unit1 == "mm")
            {
                if(unit2 == "cm")
                {
                    Console.WriteLine($"{size / 10:f3}");
                }
                else if(unit2 == "m")
                {
                    Console.WriteLine($"{size / 1000:f3}");
                }
            }
            else if (unit1 == "cm")
            {
                if (unit2 == "mm")
                {
                    Console.WriteLine($"{size * 10:f3}");
                }
                else if (unit2 == "m")
                {
                    Console.WriteLine($"{size / 100:f3}");
                }
            }
            else if (unit1 == "m")
            {
                if (unit2 == "mm")
                {
                    Console.WriteLine($"{size * 1000:f3}");
                }
                else if (unit2 == "cm")
                {
                    Console.WriteLine($"{size * 100:f3}");
                }
            }
        }
    }
}
