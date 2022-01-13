using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double record = double.Parse(Console.ReadLine());
            double size = double.Parse(Console.ReadLine());
            double timeForSwim = double.Parse(Console.ReadLine());

            //Calculatios
            double time = size * timeForSwim;
            double lostTime = Math.Floor(size / 15) * 12.5;
            double totalTime = time + lostTime;

            //Output
            if (record > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - record:f2} seconds slower.");
            }
        }
    }
}
