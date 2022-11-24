using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Numbers_from_1_to_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num > 0 && num <= 10)
            {
                Console.WriteLine(num);
                num += 1;
            }
        }
    }
}
