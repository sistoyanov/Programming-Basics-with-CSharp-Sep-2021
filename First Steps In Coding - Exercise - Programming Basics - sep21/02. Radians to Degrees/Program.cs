using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Radians_to_Degrees
{
	class Program
	{
		static void Main(string[] args)
		{
			double radian = double.Parse(Console.ReadLine());
			double degrees = radian * 180 / Math.PI;
			Console.WriteLine(degrees);
		}
	}
}
