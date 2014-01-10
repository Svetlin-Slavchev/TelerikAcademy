using System;
using System.Collections.Generic;

// Write a program that reads a string from the console and lists all different words 
// in the string along with information how many times each word is found.

namespace PrintAllDifferentWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Write a program that reads a string from the console and lists all different words" + 
                "in the string along with information how many times each word is found.";

            int count = 0;
            List<string> words = new List<string>();
            
            FindWords(text, count, words);

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }

        private static void FindWords(string text, int count, List<string> words)
        {
            string[] extractedWords = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < extractedWords.Length; i++)
            {
                int indexOfWord = text.IndexOf(extractedWords[i]);
                // searching for repeated words
                while (indexOfWord != -1)
                {
                    count++;
                    indexOfWord = text.IndexOf(extractedWords[i], indexOfWord + 1);
                }

                string result = string.Format("{0} --> {1}", extractedWords[i], count);

                // save only no repeated words
                if (!words.Contains(result))
                {
                    words.Add(result);
                }

                count = 0;
            }

        }
    }
}
