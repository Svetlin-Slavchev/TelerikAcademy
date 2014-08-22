using System;

// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace Palindromes
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = " Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe";

            string[] words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;

            foreach (var item in words)
            {
                for (int i = 0; i < item.Length / 2; i++)
                {
                    if (item[i] == item[item.Length - 1 - i])
                    {
                        count++;
                    }
                }

                if (count == item.Length / 2)
                {
                    Console.WriteLine("This word is palindrome - {0}.", item);
                }

                count = 0;
            }
        }
    }
}
