using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.USD_to_BGN
{
	class Program
	{
		static void Main(string[] args)
		{
			const double USD = 1.79549;
			double bgn = double.Parse(Console.ReadLine());
			Console.WriteLine(USD * bgn);
		}
	}
}
