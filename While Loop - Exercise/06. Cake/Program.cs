using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeWidght = int.Parse(Console.ReadLine());
            int totalCakePieces = cakeLenght * cakeWidght;

            while (totalCakePieces > 0)
            {
                string input = Console.ReadLine();
                
                if (input == "STOP")
                {
                    break;
                }

                int currentCakePieces = int.Parse(input);
                totalCakePieces -= currentCakePieces;
            }

            Console.WriteLine(totalCakePieces > 0 ? $"{totalCakePieces} pieces are left." : $"No more cake left! You need {Math.Abs(totalCakePieces)} pieces more.");
        }
    }
}
