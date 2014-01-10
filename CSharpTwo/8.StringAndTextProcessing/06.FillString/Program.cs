using System;

// Write a program that reads from the console a string of maximum 20 characters.
// If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
// Print the result string into the console.

namespace FillString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "alabala";

            if (str.Length < 20)
            {
                Console.WriteLine("The result is:\n {0}", str.PadLeft(20, '*'));
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}
