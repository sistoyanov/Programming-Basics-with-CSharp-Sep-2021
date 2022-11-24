using System;

namespace _08._Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double salary = double.Parse(Console.ReadLine());
            double score = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            //calculations
            string output = "";
            double socialScholarship = 0;
            double scholarship = 0;

            if (score > 4.5)
            {
                if(salary < 450)
                {
                    if (score >= 5.5)
                    {
                        scholarship = score * 25;
                        socialScholarship = minimalSalary * 0.35;
                    }
                    else
                    {
                        socialScholarship = minimalSalary * 0.35;
                    }
                }
                else
                {
                    if (score >= 5.5)
                    {
                        scholarship = score * 25;
                    }
                    else
                    {
                        output = "You cannot get a scholarship!";
                    }
                }

                if (socialScholarship != 0)
                {
                    if (scholarship >= socialScholarship)
                    {
                        output = $"You get a scholarship for excellent results {Math.Floor(scholarship)} BGN";
                    }
                    else
                    {
                        output = $"You get a Social scholarship {Math.Floor(socialScholarship)} BGN";
                    }
                }
                else if (scholarship !=0)
                {
                    output = $"You get a scholarship for excellent results {Math.Floor(scholarship)} BGN";
                }
            }
            else
            {
                output = "You cannot get a scholarship!";
            }

            //output
            Console.WriteLine(output);
        }


    }
}
