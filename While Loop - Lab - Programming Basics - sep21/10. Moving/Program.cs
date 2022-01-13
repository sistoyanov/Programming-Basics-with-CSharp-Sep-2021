using System;

namespace _10._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int space = width * lenght * height;
            string input = Console.ReadLine();
            int sumBoxes = 0;

            while(input != "Done")
            {
                int boxes = int.Parse(input);
                sumBoxes += boxes;

                if (sumBoxes > space)
                {
                    break;
                }
                
                input = Console.ReadLine();
            }

            if (sumBoxes > space)
            {
                Console.WriteLine($"No more free space! You need {sumBoxes - space} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{space - sumBoxes} Cubic meters left.");
            }    
        }
    }
}
