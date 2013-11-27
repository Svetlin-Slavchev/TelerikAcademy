using System;
using System.Linq;

// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

class CalculateNumberOfDatesBetweenTwoDates
{
    static void Main(string[] args)
    {
        //Console.Write("Enter a two dates in this format day.month.year:");
        // string[] dateOne = Console.ReadLine().Split('.');
        string[] dateOne = {"31", "8", "2013"};
        // reverse array because the statement of the task
        Array.Reverse(dateOne);
        int year = int.Parse(dateOne[0]);
        int month = int.Parse(dateOne[1]);
        int day = int.Parse(dateOne[2]);

        //string[] dateTwo = Console.ReadLine().Split('.');
        string[] dateTwo = { "14", "9", "2013" };
        Array.Reverse(dateTwo);
        int yearTwo = int.Parse(dateTwo[0]);
        int mountTwo = int.Parse(dateTwo[1]);
        int dayTwo = int.Parse(dateTwo[2]);

        // inicialize new DateTime objects
        DateTime firstDate = new DateTime(year, month, day);
        DateTime secondDate = new DateTime(yearTwo, mountTwo, dayTwo);
        int numberOfDays = Math.Abs((secondDate - firstDate).Days);

        Console.WriteLine("Days are: {0}", numberOfDays);
    }
}
