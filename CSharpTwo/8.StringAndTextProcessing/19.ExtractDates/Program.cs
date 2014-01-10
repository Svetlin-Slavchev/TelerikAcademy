using System;
using System.Globalization;
using System.Text.RegularExpressions;

// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
// Display them in the standard date format for Canada.

namespace ExtractDates
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Today is 30.11.2013 . Tomorow is 11.10.2013.";
            // using Regex - explanation
            // \d* - means one or more digits
            // \W - means '.'
            // \d{4} - means 4 digits
            // format to search is DD.MM.YYYY
            string pattern = @"\d{2}\.\d{2}\.\d{4}";
            Regex myReg = new Regex(pattern);
            MatchCollection matches = myReg.Matches(text);
            foreach (Match match in matches)
            {
                string str = match.ToString();
                string format = "dd.MM.yyyy";
                DateTime date = DateTime.ParseExact(str, format, CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));

            }
        }
    }
}
