using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDigitStart = int.Parse(Console.ReadLine());
            int secondDigitStart = int.Parse(Console.ReadLine());
            int firstDigitMax = int.Parse(Console.ReadLine());
            int secodDigitMax = int.Parse(Console.ReadLine());
            int firstDigitEnd = firstDigitStart + firstDigitMax;
            int secondDigitEnd = secondDigitStart + secodDigitMax;


            for (int firstDigit = firstDigitStart; firstDigit <= firstDigitEnd; firstDigit++)
            {

                for (int secondDigit = secondDigitStart; secondDigit <= secondDigitEnd; secondDigit++)
                {
                    bool isFirstPrime = true;
                    bool isSecondPrime = true;

                    for (int i = 2; i <= Math.Sqrt(firstDigit); i++)
                    {
                        if (firstDigit % i == 0)
                        {
                            isFirstPrime = false;
                            break;
                        }
                    }
                    for (int j = 2; j <= Math.Sqrt(secondDigit); j++)
                    {
                        if (secondDigit % j == 0)
                        {
                            isSecondPrime = false;
                            break;
                        }
                    }

                    if (isFirstPrime && isSecondPrime)
                    {
                        Console.WriteLine($"{firstDigit}{secondDigit}");
                    }
                }
            }
        }
    }
}
