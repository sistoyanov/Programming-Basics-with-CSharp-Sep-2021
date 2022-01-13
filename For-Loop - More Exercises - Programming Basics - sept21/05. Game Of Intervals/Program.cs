using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfMoves = int.Parse(Console.ReadLine());
            
            double result = 0;
            int numsFrom0To9 = 0;
            int numsFrom10To19 = 0;
            int numsFrom20To29 = 0;
            int numsFrom30To39 = 0;
            int numsFrom40To50 = 0;
            int invalidNumbers = 0;

            for (int i = 1; i <= numOfMoves; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (currentNum >= 0 && currentNum <= 9)
                {
                    result += currentNum * 0.20;
                    numsFrom0To9++;
                }
                else if (currentNum >= 10 && currentNum <= 19)
                {
                    result += currentNum * 0.30;
                    numsFrom10To19++;
                }
                else if (currentNum >= 20 && currentNum <= 29)
                {
                    result += currentNum * 0.40;
                    numsFrom20To29++;
                }
                else if (currentNum >= 30 && currentNum <= 39)
                {
                    result += 50;
                    numsFrom30To39++;
                }
                else if (currentNum >= 40 && currentNum <= 50)
                {
                    result += 100;
                    numsFrom40To50++;
                }
                else
                {
                    result /= 2;
                    invalidNumbers++;
                }
            }

            double percentNumsFrom0To9 = ((double)numsFrom0To9 / numOfMoves) * 100;
            double percentNumsFrom10To19 = ((double)numsFrom10To19 / numOfMoves) * 100;
            double percentNumsFrom20To29 = ((double)numsFrom20To29 / numOfMoves) * 100;
            double percentNumsFrom30To39 = ((double)numsFrom30To39 / numOfMoves) * 100;
            double percentNumsFrom40To50 = ((double)numsFrom40To50 / numOfMoves) * 100;
            double percentIvalindNumbers = ((double)invalidNumbers / numOfMoves) * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {percentNumsFrom0To9:f2}%");
            Console.WriteLine($"From 10 to 19: {percentNumsFrom10To19:f2}%");
            Console.WriteLine($"From 20 to 29: {percentNumsFrom20To29:f2}%");
            Console.WriteLine($"From 30 to 39: {percentNumsFrom30To39:f2}%");
            Console.WriteLine($"From 40 to 50: {percentNumsFrom40To50:f2}%");
            Console.WriteLine($"Invalid numbers: {percentIvalindNumbers:f2}%");
        }
    }
}
