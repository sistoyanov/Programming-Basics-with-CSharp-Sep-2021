using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 1; i <= count; i++)
            {
                if (i % 2 == 0)
                {
                    int evenNum = int.Parse(Console.ReadLine());
                    evenSum += evenNum;
                }
                else
                {
                    int oddNum = int.Parse(Console.ReadLine());
                    oddSum += oddNum;
                }
            }

            Console.WriteLine(evenSum == oddSum ? "Yes" : "No");
            Console.WriteLine(evenSum == oddSum ? $"Sum = {evenSum}" : $"Diff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}
