using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int hOfAPiece = 70;
            int wOfAPiece = 120;
            int hOfCorridor = 100;

            double hOfRoom = double.Parse(Console.ReadLine());
            double wOfRoom = double.Parse(Console.ReadLine());

            double wRoomWithoutCorridor = (wOfRoom * 100) - hOfCorridor;
            double wRoomPeices = Math.Floor(wRoomWithoutCorridor / hOfAPiece);
            double hRoomPeices = Math.Floor((hOfRoom * 100) / wOfAPiece);
            Console.WriteLine((wRoomPeices * hRoomPeices) - 3);
        }
    }
}
