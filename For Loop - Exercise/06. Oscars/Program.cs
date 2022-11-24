using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int joreyCount = int.Parse(Console.ReadLine());
            const double NEEDED_POINTS = 1250.5;
            double totalPoints = 0;
            
            totalPoints += academyPoints;
            for (int i = 1; i <= joreyCount; i++)
            {
                string currentJoreyName = Console.ReadLine();
                double currentJoreyPoints = double.Parse(Console.ReadLine());
                double currentSumPoints = (currentJoreyName.Length * currentJoreyPoints) / 2;
                totalPoints += currentSumPoints;
                if (totalPoints > NEEDED_POINTS)
                {
                    break;
                }
            }
            Console.WriteLine(totalPoints > NEEDED_POINTS ? $"Congratulations, {name} got a nominee for leading role with {totalPoints:f1}!" : $"Sorry, {name} you need {NEEDED_POINTS - totalPoints:f1} more!");

        }
    }
}
