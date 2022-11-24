using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            count *= 2;
            int iterations = count / 2;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= iterations; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum1 += num;
            }
            for (int i = 1; i <= iterations; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum2 += num;
            }
            Console.WriteLine(sum1 == sum2 ? $"Yes, sum = {sum1}" : $"No, diff = {Math.Abs(sum1 - sum2)}");
        }
    }
}
