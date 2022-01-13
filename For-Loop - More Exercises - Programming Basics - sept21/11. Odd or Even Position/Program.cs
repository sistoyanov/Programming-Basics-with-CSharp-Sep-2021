using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double evenSum = 0;
            double oddSum = 0;
            double evenMax = double.MinValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double oddMin = double.MaxValue;

            for (int i = 1; i <= num; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (number > evenMax)
                    {
                        evenMax = number;
                    }
                    if (number < evenMin)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (number > oddMax)
                    {
                        oddMax = number;
                    }
                    if (number < oddMin)
                    {
                        oddMin = number;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            Console.WriteLine(oddSum != 0 ? $"OddMin={oddMin:f2}," : "OddMin=No,");
            Console.WriteLine(oddSum != 0 ? $"OddMax={oddMax:f2}," : "OddMax=No,");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            Console.WriteLine(evenSum != 0 ? $"EvenMin={evenMin:f2}," : "EvenMin=No,");
            Console.WriteLine(evenSum != 0 ? $"EvenMax={evenMax:f2}" : "EvenMax=No");
        }
    }
}
