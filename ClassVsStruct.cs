using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    public class PointClass
    {
        public int X;
        public int Y;
    }

    public struct PointStruct
    {
        public int X;
        public int Y;
    }

    public class ClassVsStruct
    {
        public static void Run()
        {

            var classPoint1 = new PointClass { X  = 1, Y = 2 };
            var classPoint2 = classPoint1; // reference copy

            classPoint2.X = 99;

            Console.WriteLine("=== Class ===");
            Console.WriteLine($"Class Point1: X = {classPoint1.X}, Y = {classPoint1.Y}"); // X = 99
            Console.WriteLine($"Class Point2: X = {classPoint2.X}, Y = {classPoint2.Y}"); // X = 99

            var structPoint1 = new PointStruct { X = 1, Y = 2 };
            var structPoint2 = structPoint1; // value copy

            structPoint2.X = 99;

            Console.WriteLine("\n=== Struct ===");
            Console.WriteLine($"Struct Point 1: X = {structPoint1.X}, Y = {structPoint1.Y}"); // X = 1
            Console.WriteLine($"Struct Point 2: X = {structPoint2.X}, Y = {structPoint2.Y}"); // X = 99
        }
    }
}

