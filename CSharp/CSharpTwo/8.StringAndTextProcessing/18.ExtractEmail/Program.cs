using System;
using System.Collections.Generic;

// Write a program for extracting all email addresses from given text. 
// All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace ExtractEmail
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails."+ 
                " blaaa@jmaaa.bg dfghjhkjlk;ljhjh alabala@portokala.com cuiokp[iouo";

            List<string> emails = new List<string>();

            ExtractEmails(text, emails);
            PrintResult(emails);
        }

        private static void PrintResult(List<string> emails)
        {
            Console.WriteLine("Result:");
            foreach (var item in emails)
            {
                Console.WriteLine(item);
            }
        }

        private static void ExtractEmails(string text, List<string> emails)
        {
            int indexOfMonkeyA = text.IndexOf('@');
            int startEmail = text.LastIndexOf(' ', indexOfMonkeyA);
            int endEmail = text.IndexOf(' ', indexOfMonkeyA);

            string email = text.Substring(startEmail + 1, endEmail - startEmail);
            emails.Add(email);

            while (true)
            {
                indexOfMonkeyA = text.IndexOf('@', indexOfMonkeyA + 1);
                if (indexOfMonkeyA == -1)
                {
                    break;
                }
                startEmail = text.LastIndexOf(' ', indexOfMonkeyA - 1);
                endEmail = text.IndexOf(' ', indexOfMonkeyA + 1);

                email = text.Substring(startEmail + 1, endEmail - startEmail);
                emails.Add(email);
            }
        }
    }
}
