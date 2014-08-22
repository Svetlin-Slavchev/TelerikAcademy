using System;

// * Write a program to read your age from the console and print how old you will be after 10 years.

class MyAge
{
    static void Main(string[] args)
    {
        Console.Write("What is your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Aften 10 years you'll be {0} years old", age + 10);
    }
}
