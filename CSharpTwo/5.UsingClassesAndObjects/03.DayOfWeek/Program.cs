using System;

// Write a program that prints to the console which day of the week is today. Use System.DateTime.

namespace DayOfWeek
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Today.DayOfWeek);
        }
    }
}
