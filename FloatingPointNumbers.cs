using System;

namespace HelloWorld
{
    public class FloatingPointNumbers
    {
        public static void Run()
        {
        float fAnswer = 3.65f + 0.05f;
        Console.WriteLine($"float answer should be 3.7, but is {fAnswer}");

        double dbAnswer = 3.65d + 0.05d;
        Console.WriteLine($"double answer should be 3.7, but is {dbAnswer}");

        decimal dcmAnswer = 3.65m + 0.05m;
        Console.WriteLine($"decimal answer should be 3.7, but is {dcmAnswer}");
        }
    }

}
