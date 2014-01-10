using System;

// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.     // Sample input:    // Hi!// Expected output:
    // \u0048\u0069\u0021

namespace UnicodeCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word = "Hi!";

            for (int i = 0; i < word.Length; i++)
            {
                Console.Write("\\u" + ((int)word[i]).ToString("X4"));
            }
            Console.WriteLine();
        }
    }
}
