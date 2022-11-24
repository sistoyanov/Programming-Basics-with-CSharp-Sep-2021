using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Clock___part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    for (int seconds = 0; seconds <= 59 ; seconds++)
                    {
                        Console.WriteLine($"{hour} : {minutes} : {seconds} ");
                    }
                }
            }
        }
    }
}
