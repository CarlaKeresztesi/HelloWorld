using System;

namespace HelloWorld
{
    public class RandomNumber
    { //Challenge: Generate a random number between 1 and 20.
                 //User will guess it with hints until they are right.
        public static void Run()
        {
            Random randNo = new Random();
            int secret = randNo.Next(1, 21);
            int guess = 0;

            Console.WriteLine("Guess the number (1 - 20):");

            while (guess != secret)
            {
                guess = int.Parse(Console.ReadLine());

                if (guess < secret)
                    Console.WriteLine("Too low! Try again.");
                else if (guess > secret)
                    Console.WriteLine("Too high! Try again.");
                else Console.WriteLine("Correct!");
            }
        }
    }
}

