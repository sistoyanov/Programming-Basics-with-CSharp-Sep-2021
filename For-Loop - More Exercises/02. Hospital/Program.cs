using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPeoples = 0;
            int untreatedPeoples = 0;
            int daylyTreatedPeoples = 0;
            int daylyUntreatedPeoples = 0;

            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0)
                {

                    if (untreatedPeoples > treatedPeoples)
                    {
                        doctors += 1;
                    }
                }
               
                int peoples = int.Parse(Console.ReadLine());

                if (peoples < doctors)
                {
                    daylyTreatedPeoples = peoples;
                }
                else
                {
                    daylyTreatedPeoples = doctors;
                }

                daylyUntreatedPeoples = peoples - daylyTreatedPeoples;

                treatedPeoples += daylyTreatedPeoples;
                untreatedPeoples += daylyUntreatedPeoples;
            }

            Console.WriteLine($"Treated patients: {treatedPeoples}.");
            Console.WriteLine($"Untreated patients: {untreatedPeoples}.");
        }
    }
}
