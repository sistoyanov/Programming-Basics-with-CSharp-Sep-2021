using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            int failCount = 0;
            double avarageMark = 0;
            
            while (grade <= 12)
            {
                if (failCount == 2)
                {
                    break;
                }
                
                double currentMark = double.Parse(Console.ReadLine());
                
                if (currentMark < 4)
                {
                    failCount++;
                    continue;
                }
                avarageMark += currentMark;
                grade++;
            }

            Console.WriteLine(grade > 12 ? $"{name} graduated. Average grade: {avarageMark / 12:f2}" : $"{name} has been excluded at {grade} grade");
        }
    }
}
