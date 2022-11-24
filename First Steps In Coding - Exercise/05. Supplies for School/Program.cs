using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Supplies_for_School
{
	class Program
	{
		static void Main(string[] args)
		{
			//prices
			const double PEN = 5.80;
			const double MARKER = 7.20;
			const double CLEANER = 1.20;

			//input
			int penCount = int.Parse(Console.ReadLine());
			int markerCount = int.Parse(Console.ReadLine());
			int cleanerCount = int.Parse(Console.ReadLine());
			int discount = int.Parse(Console.ReadLine());

			//calculations

			double sum = (PEN * penCount) + (MARKER * markerCount) + (CLEANER * cleanerCount);
			double discountSum = sum * discount / 100;

			//output
			Console.WriteLine(sum - discountSum);
		
			
		}
	}
}
