using System;
using System.Linq;

// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class Palindromes
{
    static void Main(string[] args)
    {
        string text = "Some text ala bala ABBA, tralala.";
        string[] myArray = text.Split(new char[]{' ', ',', '.'}, StringSplitOptions.RemoveEmptyEntries);

        bool palindromes = true;
        for (int i = 0; i < myArray.Length; i++)
        {
            // check every word in array
            string word = myArray[i];
            palindromes = true;
            // check chars in word
            for (int j = 0; j < word.Length / 2; j++)
            {
                if (word[j] != word[word.Length - j - 1])
                {
                    palindromes = false; 
                }
            }

            if (palindromes == true)
            {
                Console.WriteLine("{0} is palindrom!", word);
            }
        }
    }
}
