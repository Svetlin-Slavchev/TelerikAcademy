using System;
using System.Linq;

// Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
// Write a program to test this method.

class HelloName
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        YourName(name);
    }

    static void YourName(string name)
    {
        Console.WriteLine("Hello, {0}", name);
    }
}
