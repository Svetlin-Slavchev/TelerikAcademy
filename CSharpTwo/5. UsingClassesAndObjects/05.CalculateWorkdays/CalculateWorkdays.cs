using System;

// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified 
// preliminary as array.

class CalculateWorkdays
{
    static void Main(string[] args)
    {
        string[] endDate = { "2013", "10", "30" };
        //Console.Write("Enter a date in this format year/month/day:");
        // string[] endDate = Console.ReadLine().Split('/');
        int year = int.Parse(endDate[0]);
        int month = int.Parse(endDate[1]);
        int day = int.Parse(endDate[2]);

        DateTime today = DateTime.Today;
        DateTime endDay = new DateTime(year, month, day);
        int lenDays = Math.Abs((endDay - today).Days);

        DateTime[] holidays = 
        {
            new DateTime(2013, 8, 15),
            new DateTime(2013, 8, 29),
            new DateTime(2013, 9, 3),
            new DateTime(2013, 9, 10),
            new DateTime(2013, 10, 12),
            new DateTime(2013, 10, 19)
        };

        int countWorkdays = 0;

        for (int i = 0; i < lenDays; i++)
        {
            today = today.AddDays(1);
            if ((today.DayOfWeek != DayOfWeek.Saturday) && (today.DayOfWeek != DayOfWeek.Sunday))
            {
                countWorkdays++;
            }
        }

        foreach (var days in holidays)
        {
            if ((days.DayOfWeek == DayOfWeek.Monday) || (days.DayOfWeek == DayOfWeek.Tuesday) ||
                (days.DayOfWeek == DayOfWeek.Wednesday) || (days.DayOfWeek == DayOfWeek.Thursday) ||
                (days.DayOfWeek == DayOfWeek.Friday))
            {
                countWorkdays--;
            }
        }

        Console.WriteLine("Working days is {0}.", countWorkdays);

    }
}

