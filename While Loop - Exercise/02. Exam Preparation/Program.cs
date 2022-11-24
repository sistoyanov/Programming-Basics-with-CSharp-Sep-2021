using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badMarks = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int markCount = 0;
            int badMarksCount = 0;
            string lastMArk = "";
            double markSum = 0;

            const double BAD_MARK = 4;

            while (input != "Enough")
            {
                double mark = double.Parse(Console.ReadLine());
                lastMArk = input;
                markSum += mark;
                markCount++;
                if (mark <= BAD_MARK)
                {
                    badMarksCount++;
                    if (badMarksCount >= badMarks)
                    {
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {markSum / markCount:f2}");
                Console.WriteLine($"Number of problems: {markCount}");
                Console.WriteLine($"Last problem: {lastMArk}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badMarksCount} poor grades.");
            }
        }
    }
}
