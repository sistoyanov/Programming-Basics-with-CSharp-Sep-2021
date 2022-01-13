using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int aCounter = 0;
            int bCounter = 0;
            int vCounter = 0;
            int gCounter = 0;

            for (int i = 1; i <= people; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    aCounter++;
                }
                else if (sector == "B")
                {
                    bCounter++;
                }
                else if (sector == "V")
                {
                    vCounter++;
                }
                else if (sector == "G")
                {
                    gCounter++;
                }
            }

            Console.WriteLine($"{((double)aCounter / people) * 100:f2}%");
            Console.WriteLine($"{((double)bCounter / people) * 100:f2}%");
            Console.WriteLine($"{((double)vCounter / people) * 100:f2}%");
            Console.WriteLine($"{((double)gCounter / people) * 100:f2}%");
            Console.WriteLine($"{((double)people / capacity) * 100:f2}%");
        }
    }
}
