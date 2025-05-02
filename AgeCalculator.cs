using System;

namespace HelloWorld
{
    public class AgeCalculator
    {
        public static void Run()
        {
            Console.WriteLine("Hello! What year were you born?");
            int birthYear = int.Parse(Console.ReadLine());

            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            Console.WriteLine($"You are {age} years old.");
        }
    }
}


