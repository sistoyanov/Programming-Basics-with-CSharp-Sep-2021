using System;

namespace _03._Odd_and_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double evenSum = 0;
            double oddSum = 0;
            
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            for(int i = 1; i <= n; i++)
            {
                double curretNum = double.Parse(Console.ReadLine());
                
                if (i % 2 == 0)
                {
                    evenSum += curretNum;
                    if (curretNum < evenMin)
                    {
                        evenMin = curretNum;
                    }
                    
                    if (curretNum > evenMax)
                    {
                        evenMax = curretNum;
                    }
                }
                else
                {
                    oddSum += curretNum;
                    
                    if (curretNum < oddMin)
                    {
                        oddMin = curretNum;
                    }
                    
                    if (curretNum > oddMax)
                    {
                        oddMax = curretNum;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            
            if (oddMin != double.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");  
            }
            
            if (oddMax != double.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:f2},");

            if (evenMin != double.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }
            
            if (evenMax != double.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
