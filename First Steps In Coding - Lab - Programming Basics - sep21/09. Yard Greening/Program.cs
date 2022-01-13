using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Yard_Greening
{
	class Program
	{
		static void Main(string[] args)
		{
			const double PRICE = 7.61;
			const double DISCOUNT = 0.18;
			double size = double.Parse(Console.ReadLine());
			double sum = PRICE * size;
			double sumDiscount = sum * DISCOUNT;
			Console.WriteLine($"The final price is: {sum - sumDiscount } lv.");
			Console.WriteLine($"The discount is: {sumDiscount} lv.");
		}
	}
}
