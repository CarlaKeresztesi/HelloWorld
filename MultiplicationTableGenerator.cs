using System;

namespace HelloWorld
{
    public class MultiplicationTableGenerator
    {
        public static void Run()
        {
            Console.WriteLine("Hello! Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i} x {num} = {num * i}");
            }
        }
    }
}

