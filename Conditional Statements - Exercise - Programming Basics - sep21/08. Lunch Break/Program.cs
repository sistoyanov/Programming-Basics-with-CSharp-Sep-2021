using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime * 0.125;
            double restTime = breakTime * 0.25;
            double neededTime = episodeTime + lunchTime + restTime;

            if (breakTime >= neededTime)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(breakTime - neededTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(neededTime - breakTime)} more minutes.");
            }
        }
    }
}
