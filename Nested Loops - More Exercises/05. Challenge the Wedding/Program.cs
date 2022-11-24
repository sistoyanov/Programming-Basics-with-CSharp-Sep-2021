using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalMen = int.Parse(Console.ReadLine());
            int totalWoman = int.Parse(Console.ReadLine());
            int TotalTables = int.Parse(Console.ReadLine());

            int tables = 0;
            bool isFull = false;

            for (int men = 1; men <= totalMen; men++)
            {
                for (int woman = 1; woman <= totalWoman; woman++)
                {
                    if (TotalTables <= tables)
                    {
                        isFull = true;
                        break;
                    }

                    Console.Write($"({men} <-> {woman}) ");
                    
                    tables++;
                }

                if (isFull)
                {
                    break;
                }
            }
            
        }
    }
}
