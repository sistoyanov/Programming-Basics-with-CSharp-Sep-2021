﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vacation_Books_List
{
	class Program
	{
		static void Main(string[] args)
		{
			//input
			int bookPages = int.Parse(Console.ReadLine());
			int pagesPerHour = int.Parse(Console.ReadLine());
			int days = int.Parse(Console.ReadLine());
			
			//calculations
			int hoursPerBook = bookPages / pagesPerHour;
			
			//output
			Console.WriteLine(hoursPerBook / days);
		}
	}
}
