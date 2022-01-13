using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int extraTimeWorkers = int.Parse(Console.ReadLine());

            //body
            double workingHours = (days * 8) * 0.90;
            double extraWorkingHours = (extraTimeWorkers * 2) * days;
            double totalWorkignHours = Math.Floor(workingHours + extraWorkingHours);

            //output
            Console.WriteLine(totalWorkignHours >= neededHours ? ($"Yes!{totalWorkignHours - neededHours} hours left.") : ($"Not enough time!{neededHours - totalWorkignHours} hours needed."));


        }
    }
}
