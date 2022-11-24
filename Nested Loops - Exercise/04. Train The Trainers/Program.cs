using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jurey = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            double allMarks = 0;
            int counter = 0;
            

            while (name != "Finish")
            {
                double currentMark = 0;
                counter++;

                for (int i = 1; i <= jurey ; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    currentMark += mark;
                }
                
                allMarks += currentMark / jurey;
                Console.WriteLine($"{name} - {currentMark / jurey:f2}.");
                name = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {allMarks / counter:f2}.");
        }
    }
}
