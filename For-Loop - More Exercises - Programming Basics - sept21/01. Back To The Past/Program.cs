using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int yearEnd = int.Parse(Console.ReadLine());
            
            const int YEAR_SPENDIG = 12000;

            int age = 17;
            

            for (int year = 1800; year <= yearEnd; year++)
            {
                age++;

                if (year % 2 == 0)
                {
                    money -= YEAR_SPENDIG;
                }
                else
                {
                    money -= YEAR_SPENDIG + (age * 50);
                }
            }
            Console.WriteLine(money < 0 ? $"He will need {Math.Abs(money):f2} dollars to survive." : $"Yes! He will live a carefree life and will have {money:f2} dollars left.");
        }
    }
}
