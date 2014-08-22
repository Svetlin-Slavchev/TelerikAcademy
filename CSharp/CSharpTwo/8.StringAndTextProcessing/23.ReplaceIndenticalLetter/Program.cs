using System;
using System.Text;

// Write a program that reads a string from the console and replaces all series of 
// consecutive identical letters with a single one. 
// Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
 
namespace ReplaceIndenticalLetter
{
   public class Program
    {
        static void Main(string[] args)
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder result = new StringBuilder();

            CleaningText(text, result);

            Console.WriteLine(result);
        }

        private static string CleaningText(string text, StringBuilder result)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                // if char is equal to next , do nothing
                if (text[i] == text[i + 1])
                {
                    continue;
                }
                // else append in StringBuilder
                result.Append(text[i]);
            }

            return result.ToString();
        }
    }
}
