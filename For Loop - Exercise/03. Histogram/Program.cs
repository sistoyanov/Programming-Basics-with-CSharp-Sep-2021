using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int numsTo200 = 0;
            int numsTo400 = 0;
            int numsTo600 = 0;
            int numsTo800 = 0;
            int numsAfter800 = 0;
            
            for (int i = 1; i <= count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < 200)
                {
                    numsTo200++;
                }
                else if (currentNum < 400)
                {
                    numsTo400++;
                }
                else if (currentNum < 600)
                {
                    numsTo600++;
                }
                else if (currentNum < 800)
                {
                    numsTo800++;
                }
                else
                {
                    numsAfter800++;
                }
            }

            double persentNumsTo200 = (double)numsTo200 / count * 100;
            double persentNumsTo400 = (double)numsTo400 / count * 100;
            double persentNumsTo600 = (double)numsTo600 / count * 100;
            double persentNumsTo800 = (double)numsTo800 / count * 100;
            double persentNumsAfter800 = (double)numsAfter800 / count * 100;

            Console.WriteLine($"{persentNumsTo200:f2}%");
            Console.WriteLine($"{persentNumsTo400:f2}%");
            Console.WriteLine($"{persentNumsTo600:f2}%");
            Console.WriteLine($"{persentNumsTo800:f2}%");
            Console.WriteLine($"{persentNumsAfter800:f2}%");
        }
    }
}
