using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int STEPS = 10000;
            int stepsCount = 0;
           

            while (stepsCount < STEPS)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsAfter = int.Parse(Console.ReadLine());
                    stepsCount += stepsAfter;
                    break;
                }
                
                int currenSteps = int.Parse(input);
                stepsCount += currenSteps;
            }

            if (stepsCount < STEPS)
            {
                Console.WriteLine($"{STEPS - stepsCount} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsCount - STEPS} steps over the goal!");
            }
            
        }
    }
}
