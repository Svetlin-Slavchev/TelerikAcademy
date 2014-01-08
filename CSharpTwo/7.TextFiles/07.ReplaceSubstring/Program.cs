using System;

// Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
// Ensure it will work with large files (e.g. 100 MB).

namespace ReplaceSubstring
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Write a program that replaces all occurrences of the" +
                @"substring ""startAAAA"" with the substring ""finish"" in a text file.";
            Console.WriteLine(text);

            // search for intex of 's' form "start"
            int searchSubstring = text.IndexOf("start");
            // extract start for value
            string value = text.Substring(searchSubstring, 5);
            // replace substrings
            text = text.Replace(value, "finish");

            Console.WriteLine("\nText after editing:");
            Console.WriteLine(text);
        }
    }
}
