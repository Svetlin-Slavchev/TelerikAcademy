using System;
using System.IO;

// Write a program that deletes from a text file all words that start with the prefix "test". 
// Words contain only the symbols 0...9, a...z, A…Z, _.

namespace DeleteAllWordsStartWithTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            string file = "text.txt";
            string allText = null;

            using (StreamReader reader = new StreamReader(file))
            {
                allText = reader.ReadToEnd();
                Console.WriteLine("Before:");
                Console.WriteLine(allText);
            }

            allText = allText.Replace("test", null);
            Console.WriteLine("\nAfter:");
            Console.WriteLine(allText);
        }
    }
}
