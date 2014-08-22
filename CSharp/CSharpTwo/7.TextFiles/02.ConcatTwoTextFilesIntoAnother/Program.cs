using System;
using System.IO;

// Write a program that concatenates two text files into another text file.

namespace ConcatTwoTextFilesIntoAnother
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstFile = "firstTextFile.txt";
            string secondFile = "secondTextFile.txt";
            string thirtFile = "thirtTextFile.txt";

            WriteFileToAnother(firstFile, thirtFile);
            WriteFileToAnother(secondFile, thirtFile);

            // show thirt file
            PrintResult(thirtFile);
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

            using (StreamWriter writer = new StreamWriter(thirtFile))
            {
                // this method clear thirtFile, because if you run program again all files will be overrided again in thirtFile.
                writer.Flush();
            }
        }

        private static void WriteFileToAnother(string firstFile, string thirtFile)
        {
            using (StreamReader reader = new StreamReader(firstFile))
            {
                string line = reader.ReadLine();
                using (StreamWriter writer = new StreamWriter(thirtFile, true))
                {
                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
