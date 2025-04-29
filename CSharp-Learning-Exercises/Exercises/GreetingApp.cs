using System;

namespace CSharpLearningExercises.Exercises
{ 

	public class GreetingApp
	{
		public static void Run()
		{
		Console.WriteLine("Hello! What is your name?");

		string userName = Console.ReadLine();

		Console.WriteLine($"Nice to meet you, {userName}! Welcome to C#!");

		Console.WriteLine("\nPress Enter to exit.");
		Console.ReadLine();
		}
	}
}
