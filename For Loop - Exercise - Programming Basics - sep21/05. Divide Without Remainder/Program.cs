using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int numDevideTo2 = 0;
            int numDevideTo3 = 0;
            int numDevideTo4 = 0;

            for(int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                
                if (num % 2 == 0)
                {
                    numDevideTo2++;
                }

                if (num % 3 == 0)
                {
                    numDevideTo3++;
                }

                if (num % 4 == 0)
                {
                    numDevideTo4++;
                }
            }

            Console.WriteLine($"{numDevideTo2 / n * 100:f2}%");
            Console.WriteLine($"{numDevideTo3 / n * 100:f2}%");
            Console.WriteLine($"{numDevideTo4 / n * 100:f2}%");
        }
    }
}
