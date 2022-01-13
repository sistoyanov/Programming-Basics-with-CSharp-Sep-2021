using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string passWord = "";
            int counter = 0;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if ((a * b) + (c * d) == num)
                            {
                                if (a < b && c > d)
                                {
                                    counter++;
                                    if (counter == 4)
                                    {
                                        passWord =$"{a}{b}{c}{d}";
                                    }
                                    
                                    Console.Write($"{a}{b}{c}{d} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(counter >= 4 ? $"Password: {passWord}" : "No!");

        }
    }
}
