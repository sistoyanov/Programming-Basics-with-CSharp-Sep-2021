using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double size = double.Parse(Console.ReadLine());
                Console.WriteLine($"{size * size}:f3");
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sideA * sideB}:f3");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double diameter = radius * radius;
                Console.WriteLine($"{diameter * Math.PI:f3}");
            }
            else if (figure == "triangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{0.5 * lenght * height:f3}");
            }
            else
            {
                Console.WriteLine("Wrong Format");
            }
        }
    }
}
