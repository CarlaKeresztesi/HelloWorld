using System;

namespace HelloWorld
{ //Challenge: Print numbers 1 to 50.
		//For multiples of 3, print "Fizz"
		//For multiples of 5, print "Buzz";
		//For both 3 and 5, print "FizzBuzz".

	public class FizzBuzz
	{
		public static void Run()
		{
			for (int i = 0; i <= 50; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
					Console.WriteLine("FizzBuzz");
				else if (i % 3 == 0)
					Console.WriteLine("Fizz");
				else if (i % 5 == 0)
					Console.WriteLine("Buzz");
				else Console.WriteLine(i);
			}
		}
	}
}
