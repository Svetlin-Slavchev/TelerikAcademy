using System;

// Write a program that creates an array containing all letters from the alphabet (A-Z).
// Read a word from the console and print the index of each of its letters in the array.

namespace AlpfabetArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[26];
            int count = 0;

            // creates alpfabet array
            for (char i = 'a'; i <= 'z'; i++)
            {
                arr[count] = i;
                count++;
            }

            string word = "alabala"; // string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (word[i] == arr[j])
                    {
                        Console.WriteLine("Index of [{0}] is {1}.", word[i], j);
                    }
                }
            }
        }
    }
}
