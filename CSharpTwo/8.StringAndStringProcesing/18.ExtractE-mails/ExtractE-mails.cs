using System;
using System.Linq;

// Write a program for extracting all email addresses from given text.
// All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class ExtractEmails
{
    static string mail;

    static void Main(string[] args)
    {
        string text = "My e-mails is alalbala@portokala.com and somemail@anywhere.bg.";
        int index = text.IndexOf("@");

        while (index != -1)
        {
            int indexTwo = text.LastIndexOf(" ", index);
            int indexTtree = text.IndexOf(" ", index);
            if (indexTtree == -1)
            {
                 mail = text.Substring(indexTwo + 1, text.Length - indexTwo- 2);
                 Console.WriteLine(mail);
            }
            if  ((indexTwo == -1) || (indexTtree == -1))
            {
                break;
            }
            mail = text.Substring(indexTwo + 1, indexTtree - indexTwo - 1);
            Console.WriteLine(mail);
            index = text.IndexOf("@", index + 1);
        }
    }
}
