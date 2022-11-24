using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int freePlaces = int.Parse(Console.ReadLine());

            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;
            

            while (name != "Finish")
            {
                string comand = "";
                int currentTickets = 0;

                while (comand != "End")
                {
                    comand = Console.ReadLine();

                    if (comand == "student")
                    {
                        studentTickets++;
                        currentTickets++;
                    }
                    else if (comand == "standard")
                    {
                        standardTickets++;
                        currentTickets++;
                    }
                    else if (comand == "kid")
                    {
                        kidTickets++;
                        currentTickets++;
                    }

                    if (currentTickets >= freePlaces)
                    {
                        break;
                    }
                }

                double percentageTickets = ((double)currentTickets / freePlaces) * 100;
                Console.WriteLine($"{name} - {percentageTickets:f2}% full.");

                name = Console.ReadLine();

                if (name == "Finish")
                {
                    break;
                }

                freePlaces = int.Parse(Console.ReadLine());

            }

            int totalTiclets = (studentTickets + standardTickets + kidTickets);
            double percentStudentTickets = ((double)studentTickets / totalTiclets) * 100;
            double percentStandardTickets = ((double)standardTickets / totalTiclets) * 100;
            double percentKidTickets = ((double)kidTickets / totalTiclets) * 100;

            Console.WriteLine($"Total tickets: {totalTiclets}");
            Console.WriteLine($"{percentStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percentStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentKidTickets:f2}% kids tickets.");
        }
    }
}
