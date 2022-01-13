using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {

            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double lostTime = Math.Floor(distance / 50) * 30;
            double totalTime = (distance * timeForOneMeter) + lostTime;

            if (totalTime < record)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - record:f2} seconds slower.");
            }

        }
    }
}
