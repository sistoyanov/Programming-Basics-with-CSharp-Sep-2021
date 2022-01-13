using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int num1 = 0; num1 <= num; num1++)
            {
                for (int num2 = 0; num2 <= num; num2++)
                {
                    for (int num3 = 0; num3 <= num; num3++)
                    {
                        if (num1 + num2 + num3 == num)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
