using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());

            //body
            double result = 0;
            string evenOrOdd = "";
            switch (action)
            {
                case '+':
                    result = num1 + num2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} + {num2} = {result} - {evenOrOdd}");
                    break;
                case '-':
                    result = num1 - num2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} - {num2} = {result} - {evenOrOdd}");
                    break;
                case '*':
                    result = num1 * num2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{num1} * {num2} = {result} - {evenOrOdd}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    break;
                case '%':
                    if (num2 != 0)
                    {
                        result = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    break;
            }
        }
    }
}
