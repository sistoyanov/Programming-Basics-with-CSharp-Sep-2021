using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double longSide = x * y;
            double window = 1.5 * 1.5;
            double longSides = (2 * longSide) - (2 * window);
            double shortSide = x * x;
            double door = 1.2 * 2;
            double shortSides = (2 * shortSide) - door;
            double greenPaint = (longSides + shortSides) / 3.4;

            double roofLongSides = 2 * longSide;
            double roofShortSides = 2 * (x * h / 2);
            double redPaint = (roofLongSides + roofShortSides) / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
