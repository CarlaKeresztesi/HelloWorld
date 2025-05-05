using System;

namespace HelloWorld
{
    public class IntegerDataTypes
    {
        public static void Run()
        {
            byte piccolo = byte.MaxValue;
            short small = short.MaxValue;
            int regular = int.MaxValue;
            long grande = long.MaxValue;

            Console.WriteLine("piccolo = " + piccolo);
            Console.WriteLine("small = " + small);
            Console.WriteLine("regular = " + regular);
            Console.WriteLine("grande = " + grande);
            Console.WriteLine("______________________");
            Console.WriteLine("Variable sizes");
            Console.WriteLine("----------------------");
            Console.WriteLine("piccolo's size is " + sizeof(byte));
            Console.WriteLine("small's size is " + sizeof(short));
            Console.WriteLine("regular's size is " + sizeof(int));
            Console.WriteLine("grande's size is " + sizeof(long));

            grande = piccolo; // grande = 255
            regular = (int)(piccolo + grande);
            Console.WriteLine("regular = " + regular);
            Console.Out.Flush(); //Ensures all output is written in console
        }
    }
}

