using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());

            const int WINER = 2000;
            const int FINAL = 1200;
            const int SEMI_FINAL = 720;
            
            int totalPoints = 0;
            int winsCount = 0;
            totalPoints += initialPoints;

            for (int i = 1; i <= tournamentsCount; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                    case "W":
                        totalPoints += WINER;
                        winsCount++;
                        break;
                    case "F":
                        totalPoints += FINAL;
                        break;
                    case "SF":
                        totalPoints += SEMI_FINAL;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(((double)totalPoints - initialPoints) / tournamentsCount)}");
            Console.WriteLine($"{((double)winsCount / tournamentsCount) * 100:f2}%");
        }
    }
}
