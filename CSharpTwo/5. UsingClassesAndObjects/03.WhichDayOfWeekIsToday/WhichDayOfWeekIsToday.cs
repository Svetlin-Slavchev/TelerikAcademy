using System;

// Write a program that prints to the console which day of the week is today. Use System.DateTime.

class WhichDayOfWeekIsToday
{
    static void Main(string[] args)
    {
        DayOfWeek today = DateTime.Today.DayOfWeek;
        Console.WriteLine("Today is: {0}", today);
    }
}

