using System;
using System.Collections.Generic;
using System.IO;
using InsertLinesAndWriteFileToAnother; // Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. //  Example:    //Ivan			George    //Peter			Ivan    //Maria			Maria    //George        Peter

namespace SortTextFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstFile = "firstFile.txt";
            string secondFile = "result.txt";
            List<string> names = new List<string>();
            // read firstFile
            ReadTextFromFile(firstFile, names);
            // sort list
            names.Sort();
            // save result
            SaveResultInSecondFile(secondFile, names);
            // use method from task 3
            InsertLinesAndWriteFileToAnother.Program.PrintResult(secondFile);
        }

        private static void SaveResultInSecondFile(string secondFile, List<string> names)
        {
            using (StreamWriter writer = new StreamWriter(secondFile))
            {
                for (int i = 0; i < names.Count; i++)
                {
                    writer.WriteLine(names[i]);
                }
            }
        }

        private static void ReadTextFromFile(string firstFile, List<string> names)
        {
            using (StreamReader reader = new StreamReader(firstFile))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    names.Add(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
