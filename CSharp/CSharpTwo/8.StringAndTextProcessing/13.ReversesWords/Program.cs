using System;
using System.Collections.Generic;
using System.Text;

// Write a program that reverses the words in given sentence.
// Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

namespace ReversesWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            Console.WriteLine("Text:\n{0}", text);

            string[] words = text.Split(new char[] { ' ', ',', '!' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            StringBuilder result = new StringBuilder();
            Console.WriteLine("\nResult:\n{0}", AddPunctuationsAndWhiteSpace(words, result));
        }

        private static string AddPunctuationsAndWhiteSpace(string[] words, StringBuilder result)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (i == 3)
                {
                    result.AppendFormat(words[i] + ", ");
                }
                else if (i == words.Length - 1)
                {
                    result.AppendFormat(words[i] + "!");
                }
                else
                {
                    result.AppendFormat(words[i] + " ");
                }
            }

            return result.ToString();
        }
    }
}
