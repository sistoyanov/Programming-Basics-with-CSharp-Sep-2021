using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
          
            double desks = Math.Floor((width - 1) / 0.70);
            double rows = Math.Floor(lenght / 1.2);
            double totalDesks = rows * desks - 3;

            Console.WriteLine(totalDesks);

          



        }
    }
}
