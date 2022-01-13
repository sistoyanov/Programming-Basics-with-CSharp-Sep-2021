using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiply_by_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            while (num >= 0)
            {
                num = double.Parse(Console.ReadLine());
                Console.WriteLine(num >= 0 ? $"Result: {num * 2:f2}" : "Negative number!");
            }
            
        }

    }
}
