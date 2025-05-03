using System;

namespace HelloWorld
{
    public class ReverseAWord
    {
        public static void Run()
        {
            Console.WriteLine("Hello! Enter a word:");

            string input = Console.ReadLine();
            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--) //i=input.lenght-1 => initialization starts at the last index
            {
                reversed += input[i];
            }
            Console.WriteLine($"This is the word reversed: {reversed}.");
        }
    }
}

