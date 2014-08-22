using System;
using System.Globalization;

// Write a program that reads a date and time given in the format: day.month.year hour:minute:second
// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

namespace DateAndTime
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "23.12.2013 20:20:19";
            DateTime date = DateTime.ParseExact(str, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            date = date.AddHours(6.30);

            DayOfWeek now = DateTime.Now.DayOfWeek;
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.WriteLine("{0} --> {1}", date, now);
        }
    }
}
