using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Projects_Creation
{
	class Program
	{
		static void Main(string[] args)
		{
			const int TIME = 3;
			string name = Console.ReadLine();
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine($"The architect {name} will need {TIME * number} hours to complete {number} project/s.");
		}
	}
}
