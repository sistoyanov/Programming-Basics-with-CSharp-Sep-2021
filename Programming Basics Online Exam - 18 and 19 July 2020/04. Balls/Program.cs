using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalBalls = int.Parse(Console.ReadLine());
            double totalPoionts = 0;

            int redCounter = 0;
            int orangeCounter = 0;
            int yellowCounter = 0;
            int whiteCounter = 0;
            int blackCounter = 0;
            int differentCounter = 0;

            for (int balls = 1; balls <= totalBalls; balls++)
            {
                string colour = Console.ReadLine();
                switch (colour)
                {
                    case "red":
                        redCounter++;
                        totalPoionts += 5;
                        break;
                    case "orange":
                        orangeCounter++;
                        totalPoionts += 10;
                        break;
                    case "yellow":
                        yellowCounter++;
                        totalPoionts += 15;
                        break;
                    case "white":
                        whiteCounter++;
                        totalPoionts += 20;
                        break;
                    case "black":
                        blackCounter++;
                        totalPoionts = Math.Floor(totalPoionts / 2);
                        break;
                    default:
                        differentCounter++;
                        break;
                }
            }

            Console.WriteLine($"Total points: {totalPoionts}");
            Console.WriteLine($"Points from red balls: {redCounter}");
            Console.WriteLine($"Points from orange balls: {orangeCounter}");
            Console.WriteLine($"Points from yellow balls: {yellowCounter}");
            Console.WriteLine($"Points from white balls: {whiteCounter}");
            Console.WriteLine($"Other colors picked: {differentCounter}");
            Console.WriteLine($"Divides from black balls: {blackCounter}");
        }
    }
}
