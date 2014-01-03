using System;

// Write a method that calculates the number of workdays between today and given date, passed as parameter.
// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays
// specified preliminary as array.

namespace WorkDays
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime dayStart = new DateTime(2013, 9, 23);
            DateTime dayEnd = new DateTime(2014, 1, 15);

            int workingDays = 0;

            DateTime[] holidays = {
                                 new DateTime(2013, 10, 2),
                                 new DateTime(2013, 11, 16),
                                 new DateTime(2013, 12, 31),
                                 new DateTime(2014, 1, 1)
                             };

            GetWorkingDays(ref dayStart, dayEnd, ref workingDays);

            // check if the days in array is weekends
            workingDays = CheckHolidays(workingDays, holidays);

            Console.WriteLine("Working days is : {0}.", workingDays);
        }

        private static int CheckHolidays(int workingDays, DateTime[] arr)
        {
            foreach (var day in arr)
            {
                if (day.DayOfWeek != DayOfWeek.Saturday && day.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays--;
                }
            }
            return workingDays;
        }

        private static void GetWorkingDays(ref DateTime dayStart, DateTime dayEnd, ref int workingDays)
        {
            while (dayStart != dayEnd)
            {
                if (dayStart.DayOfWeek != DayOfWeek.Saturday && dayStart.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
                // increase by one more day
                dayStart = dayStart.AddDays(1);
            }
        }
    }
}
