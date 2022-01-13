using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int neededNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isFound = false;
            int num1 = 0;
            int num2 = 0;

            for (num1 = start; num1 <= end; num1++)
            {
                
                for (num2 = start; num2 <= end; num2++)
                {
                    counter++;
                    
                    if (num1 + num2 == neededNum)
                    {
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }
            }

            if (num1 + num2 == neededNum)
            {
                Console.WriteLine($"Combination N:{counter} ({num1} + {num2} = {neededNum})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {neededNum}");
            }
            
        }
    }
}
