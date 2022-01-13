using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widght = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = widght * lenght * height;

            while (volume > 0)
            {
                string input = Console.ReadLine();
                
                if (input == "Done")
                {
                    break;
                }

                int boxCount = int.Parse(input);
                volume -= boxCount;
            }

            Console.WriteLine(volume > 0 ? $"{volume} Cubic meters left." : $"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
        }
    }
}
