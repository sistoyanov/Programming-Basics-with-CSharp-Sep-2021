using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char endSector = char.Parse(Console.ReadLine());
            int rowsCount = int.Parse(Console.ReadLine());
            int oddRowsSeats = int.Parse(Console.ReadLine());
            int totalSeats = 0;

            for (char sector = 'A'; sector <= endSector; sector++)
            {
                for (int row = 1; row <= rowsCount; row++)
                {
                    int seatsPerRow = 0;
                    
                    if (row % 2 != 0)
                    {
                        seatsPerRow = oddRowsSeats;

                    }
                    else
                    {
                        seatsPerRow = (oddRowsSeats + 2);
                    }

                    for (int seat = 1; seat <= seatsPerRow; seat++)
                    {
                        totalSeats++;
                        int currentSeat = seat + 96;
                        char seatLetter = (char)currentSeat;
                        Console.WriteLine($"{sector}{row}{seatLetter} ");
                    };
                    
                }

                rowsCount++;

            }

            Console.WriteLine(totalSeats);
        }
    }
}
