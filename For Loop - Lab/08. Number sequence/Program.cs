using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            for (int i = 0; i < count; i++)
            {
                int curretNum = int.Parse(Console.ReadLine());
                if (curretNum > maxNumber)
                {
                    maxNumber = curretNum;
                }
                if (curretNum < minNumber)
                {
                    minNumber = curretNum;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
