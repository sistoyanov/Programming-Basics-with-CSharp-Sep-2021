using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int startDigitOne = int.Parse(start.ToString()[0].ToString());
            int endDigitOne = int.Parse(end.ToString()[0].ToString());

            int startDigitTwo = int.Parse(start.ToString()[1].ToString());
            int endDigitTwo = int.Parse(end.ToString()[1].ToString());

            int startDigitTree = int.Parse(start.ToString()[2].ToString());
            int endDigitTree = int.Parse(end.ToString()[2].ToString());

            int startDigitFour = int.Parse(start.ToString()[3].ToString());
            int endDigitFour = int.Parse(end.ToString()[3].ToString());

            for (int first = startDigitOne; first <= endDigitOne; first++)
            {
                for (int second = startDigitTwo; second <= endDigitTwo; second++)
                {
                    for (int third = startDigitTree; third <= endDigitTree; third++)
                    {
                        for (int forth = startDigitFour; forth <= endDigitFour; forth++)
                        {
                            if (first % 2 != 0 && second % 2 != 0 && third % 2 != 0 && forth % 2 != 0)
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
