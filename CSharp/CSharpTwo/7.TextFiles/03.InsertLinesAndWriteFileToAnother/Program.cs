using System;
using System.IO;

// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

namespace InsertLinesAndWriteFileToAnother
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "text.txt";
            string result = "result.txt";

            InsertLinesAndWriteToAnoterFile(text, result);
            // we can also use method from previous task
            PrintResult(result);
        }

        public static void PrintResult(string result)
        {
            using (StreamReader reader = new StreamReader(result))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }

        public static void InsertLinesAndWriteToAnoterFile(string text, string result)
        {
            using (StreamReader reader = new StreamReader(text))
            {
                using (StreamWriter writer = new StreamWriter(result))
                {
                    string line = reader.ReadLine();
                    int count = 1;

                    while (line != null)
                    {
                        writer.WriteLine("{0}. {1}", count, line);
                        line = reader.ReadLine();
                        count++;
                    }
                }
            }
        }
    }
}
