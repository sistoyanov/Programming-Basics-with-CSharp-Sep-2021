﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= num; rows++)
            {
                for (int columns = 0; columns < rows; columns++)
                {
                    if (current > num)
                    {
                        isBigger = true;
                        break;
                    }

                    Console.Write($"{current} ");
                    current++;
                }

                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
