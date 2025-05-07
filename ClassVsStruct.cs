using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    public class ClassVsStruct
    {
        public static void Run()
        {
            var classPoint1 = new PointClass { X  = 1, Y = 2 };
            var classPoint2 = classPoint1;

            classPoint2.X = 99;

            Console.WriteLine("=== Class ===");
            Console.WriteLine($"Class Point1: X = {classPoint1.X}, Y = {classPoint1.Y}");
            Console.WriteLine($"Class Point2: X = {classPoint2.X}, Y = {classPoint2.Y}");
        }
    }
}

