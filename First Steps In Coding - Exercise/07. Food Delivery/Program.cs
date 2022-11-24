using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Food_Delivery
{
	class Program
	{
		static void Main(string[] args)
		{
			//price
			const double CHIKEN = 10.35;
			const double FISH = 12.40;
			const double VEGI = 8.15;
			const double DELIVERY = 2.50;

			//input 
			int chikenCount = int.Parse(Console.ReadLine());
			int fishCount = int.Parse(Console.ReadLine());
			int vegiCount = int.Parse(Console.ReadLine());

			//calcultions
			double sum = chikenCount * CHIKEN + fishCount * FISH + vegiCount * VEGI;
			double dessert = sum * 0.20;

			//output
			Console.WriteLine(sum + dessert + DELIVERY);
		}
	}
}
