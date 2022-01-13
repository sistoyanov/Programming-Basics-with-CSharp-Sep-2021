using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());
            //calculations
            double totalClothesPrice = people * clothesPrice; 
            if (people > 150)
            {
                totalClothesPrice = totalClothesPrice *= 0.9;
            }
       
            double decor = budget * 0.1;
            double spendings = totalClothesPrice + decor;
            double money;
            string output1;
            string output2;
            if (spendings > budget)
            {
                money = spendings - budget;
                output1 = "Not enough money!";
                output2 = ($"Wingard needs {money:f2} leva more.");
            }
            else
            {
                money = budget - spendings;
                output1 = "Action!";
                output2 = ($"Wingard starts filming with {money:f2} leva left.");
            }
            //Output
            Console.WriteLine(output1);
            Console.WriteLine(output2);
        }
    }
}
