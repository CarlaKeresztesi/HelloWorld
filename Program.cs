using System;
using System.Transactions;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            FloatingPointNumbers.Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Console.Out.Flush();//Ensures all output is written in console
           
        }
    }
}
