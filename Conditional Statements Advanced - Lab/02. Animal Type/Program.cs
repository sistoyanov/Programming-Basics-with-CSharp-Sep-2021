using System;

namespace _02._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            
            switch (animal)
            {
                case "dog" : animal = "mammal";break;
                case "crocodile":
                case "tortoise":
                case "snake" : animal = "reptile"; break;
                default: animal = "unknown";break;
            }
            Console.WriteLine(animal);
        }
    }
}
