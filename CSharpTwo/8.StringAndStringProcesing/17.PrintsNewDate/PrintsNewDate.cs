using System;
using System.Globalization;
using System.Linq;

// Write a program that reads a date and time given in the format: day.month.year hour:minute:second
// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

class PrintsNewDate
{
    static void Main(string[] args)
    {
        //Console.Write("Enter a date in this format day.month.year hour:minute:second");
        // string[] dateOne = Console.ReadLine().Split('.', ',', ' ');
        string[] date = { "31", "8", "2013", "3", "30", "35" };
        int day = int.Parse(date[0]);
        int month = int.Parse(date[1]);
        int year = int.Parse(date[2]);
        int hour = int.Parse(date[3]);
        int minute = int.Parse(date[4]);
        int second = int.Parse(date[5]);

        // inicialize new DateTime objects
        DateTime firstDate = new DateTime(year, month, day, hour, minute, second,DateTimeKind.Local);

        firstDate = firstDate.AddHours(6.5);
 
        string time = firstDate.ToString();
        string[] newTime = time.Split('.', '/', ',', ':', ' ');
        Console.WriteLine("{0}.{1}.{2} {3}:{4}:{5}", newTime[0], newTime[1], newTime[2], 
                                                     newTime[3], newTime[4], newTime[5]);

        Console.WriteLine(firstDate.ToString("dddd", new CultureInfo("bg-BG")));
    }
}
