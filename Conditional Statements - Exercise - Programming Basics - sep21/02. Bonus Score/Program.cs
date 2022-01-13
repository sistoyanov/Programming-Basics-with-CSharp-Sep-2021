using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;

            //calculation
            if (num <= 100)
            {
                bonus = bonus + 5;
            }
            else if (num <= 1000)
            {
                bonus = num * 0.20;
            }
            else
            {
                bonus = num * 0.10;
            }

            if (num % 2 == 0)
            {
                bonus = bonus + 1;
            }

            if (num % 10 == 5)
            {
                bonus = bonus + 2;
            }

            ///output
            Console.WriteLine(bonus); ;
            Console.WriteLine( num + bonus); ;
        }
    }
}
