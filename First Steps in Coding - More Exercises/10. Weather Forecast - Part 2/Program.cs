using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double whether = double.Parse(Console.ReadLine());

            if (whether > 4.99 && whether < 12)
            {
                Console.WriteLine("Cold");
            }
            else if(whether > 11.9 && whether < 15)
            {
                Console.WriteLine("Cool");
            }
            else if (whether > 14.9 && whether < 20.1)
            {
                Console.WriteLine("Mild");
            }
            else if (whether > 20 && whether < 26)
            {
                Console.WriteLine("Warm");
            }
            else if (whether > 25.9 && whether < 35.1)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
