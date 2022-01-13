using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dayWins = 0;
            int dayLoss = 0;
            double totalMoneyColected = 0;

            for (int day = 1; day <= days; day++)
            {
                string sport = Console.ReadLine();
                int currentDayWins = 0;
                int currentDayLoses = 0;
                double currentMoneyCollected = 0;
                
                while (sport != "Finish")
                {
                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        currentDayWins++;
                        currentMoneyCollected += 20;
                    }
                    else if (result == "lose")
                    {
                        currentDayLoses++;
                    }
                    
                    sport = Console.ReadLine();
                }

                if (currentDayWins > currentDayLoses)
                {
                    dayWins++;
                    currentMoneyCollected *= 1.10;
                }
                else
                {
                    dayLoss++;
                }

                totalMoneyColected += currentMoneyCollected;
             
            }
            
            if (dayWins > dayLoss)
            {
                totalMoneyColected *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoneyColected:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoneyColected:f2}");
            }
            
            

        }
    }
}

