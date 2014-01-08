using System;
using System.Collections.Generic;
using System.IO;
using InsertLinesAndWriteFileToAnother;

// Write a program that deletes from given text file all odd lines. The result should be in the same file.

namespace DeleteAllOddLines
{
    public class Program
    {
        static void Main(string[] args)
        {
            string file = "text.txt";
            List<string> lines = new List<string>();

            ExtractOddLines(file, lines);

            RemoveTextAndWriteOddLinesOnly(file, lines);
            // use method from task 3
            InsertLinesAndWriteFileToAnother.Program.PrintResult(file);
        }

        private static void RemoveTextAndWriteOddLinesOnly(string file, List<string> lines)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.Flush();
                for (int i = 0; i < lines.Count; i++)
                {
                    writer.WriteLine(lines[i]);
                }
            }
        }

        private static void ExtractOddLines(string file, List<string> lines)
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                int count = 1;

                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        lines.Add(line);
                    }
                    line = reader.ReadLine();
                    count++;
                }
            }
        }
    }
}
