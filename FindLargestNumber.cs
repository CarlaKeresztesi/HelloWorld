using System;
using System.Globalization;

namespace HelloWorld
{
    public class FindLargestNumber
    {
        public static void Run()
        {
            Console.WriteLine("Hello! Enter 5 numbers:");
            int[] number = new int[5];

            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            int largest = number[0];
            foreach (int n in number) //iterating over each element in a collection (here array), without modifying it.
            {
                if (n > largest)
                    largest = n;
            }
            Console.WriteLine($"The largest number is {largest}.");
        }
    }
}

