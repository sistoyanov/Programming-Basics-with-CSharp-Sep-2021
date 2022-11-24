using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double totalSquereMeters = double.Parse(Console.ReadLine());
            double grapeForSquereMeter = double.Parse(Console.ReadLine());
            double neededLitersWine = double.Parse(Console.ReadLine());
            double numberOfWorkers = double.Parse(Console.ReadLine());

            double kilogramsOfGrape = (totalSquereMeters * 0.40) * grapeForSquereMeter;
            double litersOfWine = kilogramsOfGrape / 2.5;


            if (litersOfWine < neededLitersWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitersWine - litersOfWine)} liters wine needed.");
            }
            else
            {

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersOfWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersOfWine - neededLitersWine)} liters left -> {Math.Ceiling((litersOfWine - neededLitersWine) / numberOfWorkers)} liters per person.");
                
            }
        }
    }
}
