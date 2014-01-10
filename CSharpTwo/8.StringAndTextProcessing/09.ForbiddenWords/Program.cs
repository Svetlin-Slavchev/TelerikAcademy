using System;
using System.Collections.Generic;

//We are given a string containing a list of forbidden words and a text containing some of these words. // Write a program that replaces the forbidden words with asterisks. Example:    // Microsoft announced its next generation PHP compiler today.     // It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.	//        Words: "PHP, CLR, Microsoft"//        The expected result:
    // ********* announced its next generation *** compiler today. 
    // It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace ForbiddenWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today." +
                "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            Console.WriteLine("Text:\n {0}\n", text);

            string[] forbiddenWords = {
                                              "PHP",
                                              "CLR",
                                              "Microsoft"
                                          };

            List<string> newWords = new List<string>();

            CreatNewWords(text, forbiddenWords, newWords);
            text = ReplaceWords(text, forbiddenWords, newWords);

            Console.WriteLine("Result:\n {0}", text);

        }

        private static string ReplaceWords(string text, string[] forbiddenWords, List<string> newWords)
        {
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                text = text.Replace(forbiddenWords[i], newWords[i]);
            }
            return text;
        }

        private static void CreatNewWords(string text, string[] forbiddenWords, List<string> newWords)
        {
            foreach (var item in forbiddenWords)
            {
                if (text.Contains(item))
                {
                    string newWord = "";
                    newWord = newWord.PadLeft(item.Length, '*');
                    newWords.Add(newWord);
                }
            }
        }
    }
}
