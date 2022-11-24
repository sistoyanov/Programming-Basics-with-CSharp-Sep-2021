using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int num = startNum; num <= endNum; num++)
            {
                int currentNum = num;
                int evenSum = 0;
                int oddSum = 0;
                int counter = 0;

                while (currentNum != 0)
                {
                    int currentDigit = currentNum % 10;

                    if (counter % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }

                    currentNum /= 10;
                    counter++;
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}
