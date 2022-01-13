using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Multiply_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int endDigitOne = int.Parse(num.ToString()[2].ToString());

            int endDigitTwo = int.Parse(num.ToString()[1].ToString());

            int endDigitTree = int.Parse(num.ToString()[0].ToString());

            for (int digitOne = 1; digitOne <= endDigitOne; digitOne++)
            {
                for (int digitTwo = 1; digitTwo <= endDigitTwo; digitTwo++)
                {
                    for (int digitTree = 1; digitTree <= endDigitTree; digitTree++)
                    {
                        Console.WriteLine($"{digitOne} * {digitTwo} * {digitTree} = {digitOne * digitTwo * digitTree};");
                    }
                }
            }
        }
    }
}
