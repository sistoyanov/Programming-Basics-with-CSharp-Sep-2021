using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int counter = 1;
            while (num >= counter)
            {
                Console.WriteLine(counter);
                counter = (counter * 2) + 1;
            }
        }
    }
}
