using System;

// Write a program that creates an array containing all letters from the alphabet (A-Z).
 // Read a word from the console and print the index of each of its letters in the array.

class Program
{
    static void Main(string[] args)
    {
        char[] letters = {'A', 'a', 'B', 'b', 'C', 'c', 'D', 'd', 'E', 'e', 'F', 'f', 'G', 'g', 'H', 'h', 'I', 'i', 'J', 'j', 
                             'K', 'k', 'L', 'l', 'M', 'm', 'N', 'n', 'O', 'o', 'P', 'p', 'Q', 'q', 'R', 'r', 'S', 's', 
                             'T', 't', 'U', 'u', 'V', 'v', 'W', 'W', 'X', 'x', 'Y', 'y', 'Z', 'z' };

        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (word[i] == letters[j])
                {
                    Console.WriteLine("Element[{0}] = {1}", j, word[i]);
                }
            }
        }
    }
}

