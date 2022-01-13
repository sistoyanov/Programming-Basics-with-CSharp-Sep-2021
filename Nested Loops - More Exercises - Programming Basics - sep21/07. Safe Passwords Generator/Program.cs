using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int numberOfPass = int.Parse(Console.ReadLine());

            int A = 35;
            int B = 64;

            int passwordCounter = 0;
            bool isEnough = false;

            for (int x = 1; x <= a; x++)
            {

                for (int y = 1; y <= b; y++)
                {

                    Console.Write($"{(char)A}{(char)B}{x}{y}{(char)B}{(char)A}|");

                    A++;
                    B++;

                    if (A > 55)
                    {
                        A = 35;
                    }

                    if (B > 96)
                    {
                        B = 64;
                    }

                    passwordCounter++;

                    if (passwordCounter >= numberOfPass)
                    {
                        isEnough = true;
                        break;
                    }

                }

                if (isEnough)
                {
                    break;
                }
            }


        }
    }
}
