using System;

namespace _04._Number__from_1_to_9_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("one");
            }
            else if (num is 2)
            {
                Console.WriteLine("two");
            }else if (num is 3)
            {
                Console.WriteLine("three");
            }else if (num is 4)
            {
                Console.WriteLine("four");
            }else if (num is 5)
            {
                Console.WriteLine("five");
            }else if (num is 6)
            {
                Console.WriteLine("six");
            }else if (num is 7)
            {
                Console.WriteLine("seven");
            }else if (num is 8)
            {
                Console.WriteLine("eight");
            }else if (num is 9)
            {
                Console.WriteLine("nine");
            }
        else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
