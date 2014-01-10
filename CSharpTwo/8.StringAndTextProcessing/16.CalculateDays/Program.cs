using System;

// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
// Example:
// Enter the first date: 27.02.2006// Enter the second date: 3.03.2004// Distance: 4 days
namespace CalculateDays
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = new DateTime(2013, 12, 30);
            DateTime secondDate = new DateTime(2014, 1, 5);

            TimeSpan days = secondDate - firstDate;
            Console.WriteLine("Result is : {0}", days.Days);
        }
    }
}
