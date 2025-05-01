using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld

	public class EvenOddChecker
	{
    public static void Run()
    {
        Console.WriteLine("Hello! Please enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.")
        }
    }
    }
