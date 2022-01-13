using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int maxNum = int.MinValue;
            while (num != "Stop")
            {
                int currentNum = int.Parse(num);
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
