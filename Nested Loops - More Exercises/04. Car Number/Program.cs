using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Car_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int first = start; first <= end; first++)
            {
                for (int second = start; second <= end; second++)
                {
                    for (int third = start; third <= end; third++)
                    {
                        for (int forth = start; forth <= end; forth++)
                        {
                            if (first % 2 == 0 && forth % 2 != 0 && first > forth)
                            {
                                if ((second + third) % 2 == 0)
                                {
                                    Console.Write($"{first}{second}{third}{forth} ");
                                }  
                            }

                            if (first % 2 != 0 && forth % 2 == 0 && first > forth)
                            {
                                if ((second + third) % 2 == 0)
                                {
                                    Console.Write($"{first}{second}{third}{forth} ");
                                }
                            }

                        }
                    }
                }
            }
        }
    }
}
