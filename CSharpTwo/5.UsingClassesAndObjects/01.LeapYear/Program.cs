using System;

// Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

namespace LeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            int today = DateTime.Now.Year;

            bool isLeapYear = DateTime.IsLeapYear(today);
            Console.WriteLine(isLeapYear);
        }
    }
}
