using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Deposit_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			double money = double.Parse(Console.ReadLine());
			double time = double.Parse(Console.ReadLine());
			double interest = double.Parse(Console.ReadLine());
			double sumInterest = money * (interest / 100) / 12;
			Console.WriteLine(money + (time * sumInterest));
			
		}
	}
}
