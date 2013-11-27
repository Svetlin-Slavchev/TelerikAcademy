using System;
using System.Linq;

// We are given a string containing a list of forbidden words and a text containing some of these words.
// Write a program that replaces the forbidden words with asterisks. Example:
// Words: "PHP, CLR, Microsoft"

class ForbiddenWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Text is: ");
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        Console.WriteLine(text);
        string forbiddenWordOne = "PHP";
        string forbiddenWordTwo = "CLR";
        string forbiddenWordThree = "Microsoft";
        string asteriskOne = "*";
        string asteriskTwo = "*";
        string asteriskThree = "*";
        
        for (int i = 1; i < forbiddenWordOne.Length; i++)
        {
            asteriskOne = asteriskOne + "*";
        }
        for (int i = 1; i < forbiddenWordTwo.Length; i++)
        {
            asteriskTwo = asteriskTwo + "*";
        }
        for (int i = 1; i < forbiddenWordThree.Length; i++)
        {
            asteriskThree = asteriskThree + "*";
        }

        text = text.Replace(forbiddenWordOne, asteriskOne);
        text = text.Replace(forbiddenWordTwo, asteriskTwo);
        text = text.Replace(forbiddenWordThree, asteriskThree);
        Console.WriteLine();
        Console.WriteLine("New text is :");
        Console.WriteLine(text);
    }
}
