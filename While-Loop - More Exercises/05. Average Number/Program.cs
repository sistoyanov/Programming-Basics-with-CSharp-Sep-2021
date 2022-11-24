using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= num; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += (double)currentNum;
            }

            Console.WriteLine($"{sum / num:f2}");
        }
    }
}
