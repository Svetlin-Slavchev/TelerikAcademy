using System;
using RemoveWordsThatAreListedInAnotherFile;
using System.Collections.Generic;
using System.IO;

// Write a program that reads a list of words from a file words.txt and finds how many times
// each of the words is contained in another file test.txt. 
// The result should be written in the file result.txt and the words should be sorted by the number of their occurrences
// in descending order. Handle all possible exceptions in your methods.

namespace SomeOperationWithFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string firstFile = "words.txt";
                string secondFile = "test.txt";
                string thirtFile = "result.txt";
                List<string> words = new List<string>();
                List<string> results = new List<string>();
                string allText = string.Empty;

                Console.WriteLine("Words in firstfile:");
                //read words - use method from previous task
                RemoveWordsThatAreListedInAnotherFile.Program.ReadWordFromFirstFile(firstFile, words);
                // read second file - again we using method from previous task
                allText = RemoveWordsThatAreListedInAnotherFile.Program.ReadTextFromSecondFile(secondFile, allText);

                SaveResultInList(words, results, allText);

                WriteResultsInThirtFile(thirtFile, results);

                Console.WriteLine("\nResult:");
                PrintResult(thirtFile);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid argument!");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index!");
            }
            catch (Exception)
            {
                Console.WriteLine("There is some error with this program!");
            }
        }

        private static void PrintResult(string thirtFile)
        {
            using (StreamReader reader = new StreamReader(thirtFile))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }

        private static void WriteResultsInThirtFile(string thirtFile, List<string> results)
        {
            using (StreamWriter writer = new StreamWriter(thirtFile))
            {
                foreach (var item in results)
                {
                    writer.WriteLine(item);
                }
            }
        }

        private static void SaveResultInList(List<string> words, List<string> results, string allText)
        {
            int count = 1;
            for (int i = 0; i < words.Count; i++)
            {
                int index = allText.IndexOf(words[i]);
                while (index != -1)
                {
                    index = allText.IndexOf(words[i], index + 1);
                    count++;
                }

                results.Add(string.Format("Word {0} occurs {1} times in text.", words[i], count));
                count = 1;
            }
        }
    }
}
