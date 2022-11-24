using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int allFloors = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());

            for (int floor = allFloors; floor >= 1; floor--)
            {
                for (int room = 0; room < roomsPerFloor; room++)
                {
                    if (floor == allFloors)
                    {
                        Console.Write($"L{floor}{room} ");
                    }
                    else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                    
                }
                
                Console.WriteLine();
            }
        }
    }
}
