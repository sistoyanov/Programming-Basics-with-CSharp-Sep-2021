using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int minNum = int.MaxValue;
            while (num != "Stop")
            {
                int currentNum = int.Parse(num);
                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
