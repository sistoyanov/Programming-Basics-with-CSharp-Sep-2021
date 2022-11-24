using System;

namespace _09._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int counter = 1;
            int exclusionCounter = 0;
            double sum = 0;

            for (int i = 1; i <= 12; i++)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    sum += grade;
                    counter++;
                }
                else
                {
                    i--;
                    exclusionCounter++;
                }

                if (exclusionCounter >= 2)
                {
                    break;
                }
            }
            if (exclusionCounter >= 2)
            {
                Console.WriteLine($"{name} has been excluded at {counter} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
            }
            
            

        }
    }
}
