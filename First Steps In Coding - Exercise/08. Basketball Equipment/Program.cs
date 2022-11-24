using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Basketball_Equipment
{
	class Program
	{
		static void Main(string[] args)
		{
			//input 
			int price = int.Parse(Console.ReadLine());

			//calculations
			double shoes = price - price * 0.40;
			double clothes = shoes - shoes * 0.20;
			double ball = clothes / 4;
			double stuff = ball / 5;

			//output
			Console.WriteLine(price + shoes + clothes + ball + stuff);
		}
	}
}
