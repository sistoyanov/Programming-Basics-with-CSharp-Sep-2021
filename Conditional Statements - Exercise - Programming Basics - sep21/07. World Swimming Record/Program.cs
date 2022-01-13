using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            //calculations
            double resistance = Math.Floor(distance / 15) * 12.5;
            double time = (distance * seconds) + resistance;
           
            string output;
            if (time < record)
            {
                output = ($"Yes, he succeeded! The new world record is {time:f2} seconds.");
            }
            else
            {
                output = ($"No, he failed! He was {time - record:f2} seconds slower.");
            }

            //output
            Console.WriteLine(output);
        }
    }
}
