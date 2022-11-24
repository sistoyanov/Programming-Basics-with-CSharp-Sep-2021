using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GPU = 250;
            double budget = double.Parse(Console.ReadLine());
            int numGpu = int.Parse(Console.ReadLine());
            int numCpu = int.Parse(Console.ReadLine());
            int numRam = int.Parse(Console.ReadLine());

            int gpuPrice = GPU * numGpu;
            double cpuPrice = gpuPrice * 0.35 * numCpu;
            double ramPrice = gpuPrice * 0.10 * numRam;
            double totalPrice = gpuPrice + cpuPrice + ramPrice;
            if (numGpu > numCpu)
            {
                double discount = totalPrice * 0.15;
                totalPrice -= discount;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }
        }
    }
}
