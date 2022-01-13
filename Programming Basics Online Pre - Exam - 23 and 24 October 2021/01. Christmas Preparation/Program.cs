using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Christmas_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
   
            const double PAPER = 5.80;
            const double CLOTH = 7.20;
            const double GLUE = 1.20;

            int numPaper = int.Parse(Console.ReadLine());
            int numCloth = int.Parse(Console.ReadLine());
            double literGlue = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double totalSum = (numPaper * PAPER) + (numCloth * CLOTH) + (literGlue * GLUE);
            double totalDiscount = totalSum * discount / 100;

            Console.WriteLine($"{totalSum - totalDiscount:f3}");
        }
    }
}
