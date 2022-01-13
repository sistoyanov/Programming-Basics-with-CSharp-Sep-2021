using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int daysOff = int.Parse(Console.ReadLine());

            const int DAYS_OF_YEAR = 365;
            const int MINUTE_FOR_PLAY_FOR_YEAR = 30000;
            
            int playMinutesForDays = (DAYS_OF_YEAR - daysOff) * 63;
            int playMinutesForDaysOff = daysOff * 127;
            int totalPlayMinutes = playMinutesForDays + playMinutesForDaysOff;

            if (totalPlayMinutes > MINUTE_FOR_PLAY_FOR_YEAR)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{(totalPlayMinutes - MINUTE_FOR_PLAY_FOR_YEAR) / 60} hours and {(totalPlayMinutes - MINUTE_FOR_PLAY_FOR_YEAR) % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(MINUTE_FOR_PLAY_FOR_YEAR - totalPlayMinutes) / 60} hours and {(MINUTE_FOR_PLAY_FOR_YEAR - totalPlayMinutes) % 60} minutes less for play");
            }
        }
    }
}
