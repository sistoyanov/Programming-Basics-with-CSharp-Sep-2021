using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int browsersCount = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            const int FACEBOOK = 150;
            const int INSTAGRAM = 100;
            const int REDDIT = 50;

            for (int i = 1; i <= browsersCount; i++)
            {
                string currentBrowser = Console.ReadLine();
                switch (currentBrowser)
                {
                    case "Facebook":
                        salary -= FACEBOOK;
                        break;
                    case "Instagram":
                        salary -= INSTAGRAM;
                        break;
                    case "Reddit":
                        salary -= REDDIT;
                        break;
                    default:
                        break;
                }
                if (salary <= 0)
                {
                    break;
                }
            }
            Console.WriteLine(salary <= 0 ? "You have lost your salary." : $"{salary}");
        }
    }
}
