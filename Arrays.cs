using System;

namespace HelloWorld
{
    public class Arrays
    {
        public static void Run()
        {
            string[] arrayOfStrings = { "how", "now", "brown", "cow" };
            int[] arrayOfInts = { 0, 0, 1, 2, 3 };
            char[] arrayOfLetters = {};

            Console.WriteLine($"arrayOfStrings has {arrayOfStrings.Length} elements");
            Console.WriteLine($"arrayOfInts has {arrayOfInts.Length} elements");
            Console.WriteLine($"arrayOfLetters has {arrayOfLetters.Length} elements");

            Console.WriteLine($"{arrayOfStrings[0]} {arrayOfStrings[1]} {arrayOfStrings[2]} {arrayOfStrings[3]}");
            Console.WriteLine($"{arrayOfInts[1]} {arrayOfInts[2]} {arrayOfInts[3]} {arrayOfInts[4]}");
            Console.WriteLine($"{arrayOfStrings[arrayOfInts[3]]}");

            string cowColor = arrayOfStrings[arrayOfInts[3]];

            arrayOfLetters = new char[cowColor.Length];
            arrayOfLetters[0] = 'c';
            arrayOfLetters[1] = cowColor[1]; //assigning values to arrayOfLetters by accessing the cowColor string variable in the same way we access an array - a string is a special array of char
            arrayOfLetters[2] = cowColor[2];
            arrayOfLetters[3] = cowColor[3];
            arrayOfLetters[4] = cowColor[4];

        }
    }
}
