using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumOfPrimeNumbers = 0;
            int sumOfNonPrimeNumbers = 0;

            while (input != "stop")
            {
                int currentNum = int.Parse(input);

                if (currentNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    int counter = 0;

                    for (int num = 1; num <= currentNum; num++)
                    {
                        if (currentNum % num == 0)
                        {
                            counter++;
                        }
                    }

                    if (counter == 2)
                    {
                        sumOfPrimeNumbers += currentNum;
                    }
                    else
                    {
                        sumOfNonPrimeNumbers += currentNum;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNumbers}");
        }
    }
}
