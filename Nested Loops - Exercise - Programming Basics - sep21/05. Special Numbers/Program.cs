using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int num1 = 1; num1 <= 9 ; num1++)
            {
                for (int num2 = 1; num2 <= 9; num2++)
                {
                    for (int num3 = 1; num3 <= 9; num3++)
                    {
                        for (int num4 = 1; num4 <= 9; num4++)
                        {
                            if (num % num1 == 0 && num % num2 == 0 && num % num3 == 0 && num % num4 ==0)
                            {
                                Console.Write($"{num1}{num2}{num3}{num4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
