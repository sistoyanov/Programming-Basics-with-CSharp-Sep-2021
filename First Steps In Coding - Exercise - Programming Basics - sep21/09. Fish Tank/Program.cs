using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Fish_Tank
{
	class Program
	{
		static void Main(string[] args)
		{
			//input
			int lenght = int.Parse(Console.ReadLine());
			int widht = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());
			double percent = double.Parse(Console.ReadLine());

			//calculations
			double volume = lenght * widht * height;
			double liters = volume / 1000;
			double occupied = liters * percent / 100;

			//output
			Console.WriteLine(liters - occupied);
		}
	}
}
