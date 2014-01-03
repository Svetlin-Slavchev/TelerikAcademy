using System;

// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”).
// Write a program to test this method.

namespace AskForNameMethod
{
    public class Program
    {
        static void Main()
        {
            string yourName = null;

            WhatIsYourName(ref yourName);

            //for test the method
            Console.WriteLine("Your name is : {0}", yourName);
        }

        public static string WhatIsYourName(ref string yourName)
        {
            Console.WriteLine(@"""WhatIsYourName?"", said mashine and add - ""Write it, please!""");
            yourName = Console.ReadLine();

            return yourName;
        }
    }
}
