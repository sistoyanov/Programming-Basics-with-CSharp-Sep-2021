using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char miss = char.Parse(Console.ReadLine());

            int counter = 0;

            for (char first = start; first <= end; first++)
            {
                for (char second = start; second <= end; second++)
                {
                    for (char third = start; third <= end; third++)
                    {
                        if (first != miss && second != miss && third != miss)
                        {
                            counter++;
                            Console.Write($"{first}{second}{third} ");
                        }
                        
                    }
                }
            }

            Console.Write(counter);
        }
    }
}
