using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Repainting
{
	class Program
	{
		static void Main(string[] args)
		{
			//priceses
			const double PLASTIC = 1.50;
			const double PAINT = 14.50;
			const double THINNER = 5;
			const double BAGS = 0.40;

			//input
			int plasticCount = int.Parse(Console.ReadLine());
			int paintCount = int.Parse(Console.ReadLine());
			int thinnerCount = int.Parse(Console.ReadLine());
			int hoursCount = int.Parse(Console.ReadLine());

			//calculations
			double plasticSum = plasticCount + 2;
			double paintSum = paintCount + paintCount * 0.10;
			double sum = plasticSum * PLASTIC + paintSum * PAINT + thinnerCount * THINNER + BAGS;
			double hourPrice = sum * 0.30;
			
			//output
			Console.WriteLine(sum + hourPrice * hoursCount);

		}
	}
}
