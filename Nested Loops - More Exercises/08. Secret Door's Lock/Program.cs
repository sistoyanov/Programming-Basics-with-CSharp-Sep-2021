using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int prime = 0;

            for (int firstDigit = 2; firstDigit <= num1; firstDigit+=2)
            {
                for (int secondDigit = 2; secondDigit <= num2; secondDigit++)
                {
                    int counter = 0;
                    bool isPrime = false;

                    for (int currentDigit = 1; currentDigit <= num2; currentDigit++)
                    {
                        if (secondDigit % currentDigit == 0)
                        {
                            counter++;
                        }
                    }

                    if (counter == 2)
                    {
                        prime = secondDigit;
                        isPrime = true;
                    }

                    if (isPrime)
                    {

                        for (int thirdDigit = 2; thirdDigit <= num3; thirdDigit+=2)
                        {
                            Console.WriteLine($"{firstDigit} {prime} {thirdDigit}");

                        }
                    }

                }
            }
        }
    }
}
