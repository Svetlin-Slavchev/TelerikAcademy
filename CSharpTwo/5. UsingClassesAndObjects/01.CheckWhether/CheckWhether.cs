using System;

// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

class CheckWhether
{
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        CheckWhetherIsLeap(year);
    }

    static void CheckWhetherIsLeap(int year)
    {
        DateTime.IsLeapYear(year);   // Use DateTime method IsLeapYear
        Console.WriteLine("Is this year is leap? {0}", DateTime.IsLeapYear(year));
    }
}

