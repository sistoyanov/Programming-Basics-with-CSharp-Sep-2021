using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int k = 1; k <= 9; k++)
                {
                    for (int l = 1; l <= 9; l++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {

                            if (i + k == l + j && num % (i + k) == 0)
                            {
                                Console.Write($"{i}{k}{l}{j} ");

                            }

                        }
                    }
                }
            }
        }
    }
}
