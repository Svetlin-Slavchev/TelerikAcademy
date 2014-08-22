using System;

// Modify the solution of the previous problem to replace only whole words (not substrings).

namespace ReplaceOnlyWholeWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Write a program that replaces all occurrences of the" +
                @"substring ""start"" with the substring ""finish"" in a text file.";
            Console.WriteLine(text);

            // replace substrings
            text = text.Replace("start", "finish");

            Console.WriteLine("\nText after editing:");
            Console.WriteLine(text);
        }
    }
}
