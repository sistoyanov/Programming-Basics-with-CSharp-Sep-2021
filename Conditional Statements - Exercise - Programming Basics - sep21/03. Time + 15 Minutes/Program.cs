using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //calsulations
            minutes = minutes + 15;

            if (minutes >= 60)
            {
                hour = hour + 1;
                minutes = minutes - 60;
            }

            if (hour >= 24)
            {
                hour = hour - 24;
            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
            
        }
    }
}
