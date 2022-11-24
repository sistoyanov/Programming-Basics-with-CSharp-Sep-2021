using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int prime = 0;

            for (int i = 1; i <= num1; i++)
            {
                for (int j = 2; j <= num2; j++)
                {
                    int counter = 0;
                    bool isPrime = false;

                    for (int h = 1; h <= num2; h++)
                    {
                        if (j % h == 0)
                        {
                            counter++;
                        }
                    }

                    if (counter == 2)
                    {
                        prime = j;
                        isPrime = true;
                    }

                    if (isPrime)
                    {

                        for (int k = 1; k <= num3; k ++ )
                        {
                            if (i % 2 == 0 && k % 2 ==0)
                            {
                                Console.WriteLine($"{i} {prime} {k}");
                            }
                            
                        }
                    }
      
                }
            }
  
        }
    }
}
