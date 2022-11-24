using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Pet_Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			const double DOGFoodPrice = 2.50;
			const double CATFoodPrice = 4.00;
			double dogFoodNumber = double.Parse(Console.ReadLine());
			double catFoodNumber = double.Parse(Console.ReadLine());
			Console.WriteLine($"{DOGFoodPrice * dogFoodNumber + CATFoodPrice * catFoodNumber} lv.");
		}
	}
}
