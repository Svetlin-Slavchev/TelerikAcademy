using System;
using System.Collections.Generic;

// Write a program that reads a string from the console and prints all different letters in the string 
// along with information how many times each letter is found.

namespace PrintAllDiferentLetters
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Write a program that";
            int count = 0;
            List<string> letters = new List<string>();

            FindLetters(text, count, letters);

            foreach (var item in letters)
            {
                Console.WriteLine(item);
            }
        }

        private static void FindLetters(string text, int count, List<string> letters)
        {
            for (int i = 0; i < text.Length; i++)
            {
                int index = text.IndexOf(text[i]);
                while (index != -1)
                {
                    index = text.IndexOf(text[i], index + 1);
                    count++;
                }

                string result = string.Format("{0} --> {1}", text[i], count);

                // save only no repeated letters
                if (!letters.Contains(result))
                {
                    letters.Add(result);
                }

                count = 0;
            }
        }
    }
}
