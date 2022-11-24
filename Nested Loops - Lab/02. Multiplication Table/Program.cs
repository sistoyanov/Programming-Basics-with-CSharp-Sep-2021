using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numA = 1; numA <= 10; numA++)
            {
                for (int numB = 1; numB <= 10; numB++)
                {
                    Console.WriteLine($"{numA} * {numB} = {numA * numB}");
                }
            }
        }
    }
}
