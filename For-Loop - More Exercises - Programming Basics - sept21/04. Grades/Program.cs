using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            int numFail = 0;
            int numBelow4 = 0;
            int numBelow5 = 0;
            int numTop = 0;
            double totalMarks = 0;

            for (int i = 1; i <= numOfStudents; i++)
            {
                double mark = double.Parse(Console.ReadLine());

                if (mark < 3)
                {
                    numFail++;
                    totalMarks += mark;
                }
                else if (mark < 4)
                {
                    numBelow4++;
                    totalMarks += mark;
                }
                else if (mark < 5)
                {
                    numBelow5++;
                    totalMarks += mark;
                }
                else
                {
                    numTop++;
                    totalMarks += mark;
                }
            }

            double TopPercent = ((double)numTop / numOfStudents) * 100;
            double below5Percent = ((double)numBelow5 / numOfStudents) * 100;
            double below4Percent = ((double)numBelow4 / numOfStudents) * 100;
            double failPercent = ((double)numFail / numOfStudents) * 100;
            double avarageMark = totalMarks / numOfStudents;

            Console.WriteLine($"Top students: {TopPercent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {below5Percent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {below4Percent:f2}%");
            Console.WriteLine($"Fail: {failPercent:f2}%");
            Console.WriteLine($"Average: {avarageMark:f2}");
        }
    }
}
