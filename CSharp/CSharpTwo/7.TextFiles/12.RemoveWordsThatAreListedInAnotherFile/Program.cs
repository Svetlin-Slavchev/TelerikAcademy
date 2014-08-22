using System;
using System.Collections.Generic;
using System.IO;

// Write a program that removes from a text file all words listed in given another text file. 
// Handle all possible exceptions in your methods.

namespace RemoveWordsThatAreListedInAnotherFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string firstFile = "firstFile.txt";
                string secondFile = "secondFile.txt";
                List<string> words = new List<string>();
                string allText = null;

                Console.WriteLine("Words:");

                // read firstfile
                ReadWordFromFirstFile(firstFile, words);
                // read second
                allText = ReadTextFromSecondFile(secondFile, allText);

                Console.WriteLine("\nBefore:");
                Console.WriteLine(allText);
                // remove words form firstfile
                allText = RemoveWords(words, allText);

                Console.WriteLine("\nAfter:");
                Console.WriteLine(allText);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("There is mising file!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid argument!");
            }
            catch (Exception)
            {
                Console.WriteLine("There is some error with application!");
            }
        }

        public static string RemoveWords(List<string> words, string allText)
        {
            for (int i = 0; i < words.Count; i++)
            {
                allText = allText.Replace(words[i], null);
            }
            return allText;
        }

        public static string ReadTextFromSecondFile(string secondFile, string allText)
        {
            using (StreamReader reader = new StreamReader(secondFile))
            {
                allText = reader.ReadToEnd();
            }

            return allText;
        }

        public static void ReadWordFromFirstFile(string firstFile, List<string> words)
        {
            using (StreamReader reader = new StreamReader(firstFile))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    words.Add(line);
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
