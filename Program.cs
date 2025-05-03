using System;
using System.Transactions;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTableGenerator.Run();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
