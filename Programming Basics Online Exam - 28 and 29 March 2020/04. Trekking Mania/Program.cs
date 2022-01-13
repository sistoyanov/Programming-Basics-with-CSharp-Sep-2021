using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            int totalPeopleCount = 0;
            int groupTo5 = 0;
            int groupTo12 = 0;
            int groupTo25 = 0;
            int groupTo40 = 0;
            int groupMopreThan40 = 0;

            for (int i = 1; i <= groupsCount; i++)
            {
                int currentGroupCount = int.Parse(Console.ReadLine());
                totalPeopleCount += currentGroupCount;
                if (currentGroupCount <= 5)
                {
                    groupTo5 += currentGroupCount;
                }
                else if (currentGroupCount <= 12)
                {
                    groupTo12 += currentGroupCount;
                }
                else if (currentGroupCount <= 25)
                {
                    groupTo25 += currentGroupCount;
                }
                else if (currentGroupCount <= 40)
                {
                    groupTo40 += currentGroupCount;
                }
                else
                {
                    groupMopreThan40 += currentGroupCount;
                }
            }

            double percentPeopleMusalla = ((double)groupTo5 / totalPeopleCount) * 100;
            double percentPeopleMontblanc = ((double)groupTo12 / totalPeopleCount) * 100;
            double percentPeopleKilimanjaro = ((double)groupTo25 / totalPeopleCount) * 100;
            double percentPeopleK2 = ((double)groupTo40 / totalPeopleCount) * 100;
            double percentPeopleEverest = ((double)groupMopreThan40 / totalPeopleCount) * 100;

            Console.WriteLine($"{percentPeopleMusalla:f2}%");
            Console.WriteLine($"{percentPeopleMontblanc:f2}%");
            Console.WriteLine($"{percentPeopleKilimanjaro:f2}%");
            Console.WriteLine($"{percentPeopleK2:f2}%");
            Console.WriteLine($"{percentPeopleEverest:f2}%");
        }
    }
}
