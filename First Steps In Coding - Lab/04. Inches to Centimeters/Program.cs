﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Inches_to_Centimeters
{
	class Program
	{
		static void Main(string[] args)
		{
			double input = double.Parse(Console.ReadLine());
			double output = input * 2.54;
			Console.WriteLine(output);
		}
	}
}
