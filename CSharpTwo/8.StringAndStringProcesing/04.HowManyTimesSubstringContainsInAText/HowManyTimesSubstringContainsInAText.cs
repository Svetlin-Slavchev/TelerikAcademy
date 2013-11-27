using System;
using System.Linq;

// Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
// Example: The target substring is "in".

class HowManyTimesSubstringContainsInAText
{
    static void Main(string[] args)
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        // Ignore up and lower letters
        int index = text.IndexOf("in", StringComparison.InvariantCultureIgnoreCase);
        int count = 0;
        while (index != -1)
        {
            count++;
            index = text.IndexOf("in", index + 1, StringComparison.InvariantCultureIgnoreCase);           
        }
        Console.WriteLine("This substring contains {0} times.", count);
    }
}
