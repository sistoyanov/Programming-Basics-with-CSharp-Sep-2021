using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string whether = Console.ReadLine();

            if (whether == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
