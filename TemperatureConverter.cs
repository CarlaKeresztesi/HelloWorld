using System;

namespace HelloWorld
{
	public class TemperatureConverter
	{
        public static void Run()
        {
            Console.WriteLine("Hello! Enter temperature in degrees Celsius:");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C is {fahrenheit}°F.");
        }
    }
}
