using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int poolVolume = int.Parse(Console.ReadLine());
            int pipeOneVolume = int.Parse(Console.ReadLine());
            int pipeTwoVolume = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            //body
            double totalPipeOneVolume = pipeOneVolume * time;
            double totalPipeTwoVolume = pipeTwoVolume * time;
            double totalPipeVolume = totalPipeOneVolume + totalPipeTwoVolume;
            if (poolVolume >= totalPipeVolume)
            {


                Console.WriteLine($"The pool is {(totalPipeVolume / poolVolume) * 100:f2}% full. Pipe 1: {(totalPipeOneVolume / totalPipeVolume) * 100:f2}%. Pipe 2: {(totalPipeTwoVolume / totalPipeVolume) * 100:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {time} hours the pool overflows with {totalPipeVolume - poolVolume:f2} liters.");
            }
        }
    }
}
