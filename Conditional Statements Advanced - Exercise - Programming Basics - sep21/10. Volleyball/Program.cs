using System;

namespace _10._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int daysOff = int.Parse(Console.ReadLine());
            int weekendsToTravel = int.Parse(Console.ReadLine());
            
            int weekends = 48;
            double weekendsSofia = (weekends - weekendsToTravel) * 0.75;
            double daysOffToPlay = daysOff * 0.666667;
            double totalDaysToPlay = weekendsToTravel + weekendsSofia + daysOffToPlay;

            if (yearType == "leap")
            {
                totalDaysToPlay *= 1.15;
                Console.WriteLine(Math.Floor(totalDaysToPlay));
            }
            else if (yearType == "normal")
            {
                Console.WriteLine(Math.Floor(totalDaysToPlay));
            }
            else
            {
                Console.WriteLine("Wrong input for year type");
            }
        }
    }
}
