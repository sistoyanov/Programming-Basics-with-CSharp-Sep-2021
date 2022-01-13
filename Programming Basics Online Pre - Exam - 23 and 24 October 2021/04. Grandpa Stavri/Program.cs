using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            double totalLitters = 0;
            double totalDegrees = 0;

            for (int day = 1; day <= days; day++)
            {
                double currentLitters = double.Parse(Console.ReadLine());
                double currentDegrees = double.Parse(Console.ReadLine());

                totalLitters += currentLitters;
                totalDegrees += currentLitters * currentDegrees;
            }

            double avarageDegrees = totalDegrees / totalLitters;

            Console.WriteLine($"Liter: {totalLitters:f2}");
            Console.WriteLine($"Degrees: {avarageDegrees:f2}");

            if (avarageDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (avarageDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }
        }
    }
}
