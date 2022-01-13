using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int maxGoals = 0;
            string name = "";

            while (input != "END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    name = input;

                    
                }

                if (goals >= 10)
                {
                    break;
                }

                input = Console.ReadLine();

            }

            Console.WriteLine($"{name} is the best player!");
            Console.WriteLine(maxGoals >= 3 ? $"He has scored {maxGoals} goals and made a hat-trick !!!" : $"He has scored {maxGoals} goals.");
        }
    }
}
