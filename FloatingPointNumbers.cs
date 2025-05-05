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

            fAnswer = 0.09f * 100f;
            float fAnswer2 = 0.09f * 99.9999999999f;
            Console.WriteLine($"float answer should be {fAnswer}, but is {fAnswer2}");

            bool areEqual = fAnswer == fAnswer2;
            Console.WriteLine($"float {fAnswer} is equal to {fAnswer2}: {areEqual}");

            dbAnswer = 0.09f * 100d;
            double dbAnswer2 = 0.09d * 99.99999999999999999d;
            Console.WriteLine($"double answer should be {dbAnswer}, but is {dbAnswer2}");

            areEqual = dbAnswer == dbAnswer2;
            Console.WriteLine($"double {dbAnswer} is equal to {dbAnswer2}: {areEqual}");

            dcmAnswer = 0.09m * 100m;
            decimal dcmAnswer2 = 0.09m * 99.9999999999999999999m;
            Console.WriteLine($"decimal answer should be {dcmAnswer}, but is {dcmAnswer2}");

            areEqual = dcmAnswer == dcmAnswer2;
            Console.WriteLine($"decimal {dcmAnswer} is equal to {dcmAnswer2}: {areEqual}");

            int one = 1;
            int ten = 10;

            dbAnswer = one / ten;
            Console.WriteLine($"float answer should be 0.1, but is {dbAnswer}");


        }
    }

}
