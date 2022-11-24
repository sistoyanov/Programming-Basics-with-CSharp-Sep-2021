using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            //body

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;
            int difference = 0;
            int hour = 0;
            int minutes = 0;

            if (arrivalTime > examTime)
            {
                Console.WriteLine("Late");
                difference = arrivalTime - examTime;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours after the start");
                }
            }
            else if (arrivalTime < examTime - 30)
            {
                Console.WriteLine("Early");
                difference = examTime - arrivalTime;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hour}:{minutes:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On Time");
                difference = examTime - arrivalTime;
                Console.WriteLine( difference > 0 ? ($"{difference} minutes before the start") : "");
            }
        }
    }
    
}
