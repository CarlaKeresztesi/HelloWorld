using System;

namespace HelloWorld
{
    public class NullCoalescingOp
    {  //Challenge: Writing a small user profile display program.
                   //Sometimes users provide a nickname, sometimes they don't.
                   //Use the ?? operator to make sure that a fallback value "Guest"
                   //is shown when nickname = null.
        public static void Run()
        {
            string nickname = null;
            string displayName = nickname ?? "Guest";

            Console.WriteLine("Welcome, " + displayName + "!");
        }
    }
}

