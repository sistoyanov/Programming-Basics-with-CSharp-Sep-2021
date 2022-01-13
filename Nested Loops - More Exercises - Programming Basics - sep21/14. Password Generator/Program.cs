using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int first = 1; first <= n; first++)
            {
                for (int second = 1; second <= n; second++)
                {
                    for (int third = 1; third <= l; third++)
                    {
                        for (int forth = 1; forth <= l; forth++)
                        {
                            for (int fifth = 1; fifth <= n; fifth++)
                            {
                                if (first < fifth && second < fifth)
                                {
                                    int thirdToLetter = third + 96;
                                    int forthToLetter = forth + 96;
                                    Console.Write($"{first}{second}{(char)thirdToLetter}{(char)forthToLetter}{fifth} ");
                                }
                            }
                            
                        }
                    }

                    
                }
            }

          
        }
    }
}
