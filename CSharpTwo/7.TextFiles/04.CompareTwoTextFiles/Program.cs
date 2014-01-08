using System;
using System.IO;

// Write a program that compares two text files line by line and prints the number of lines
// that are the same and the number of lines that are different. Assume the files have equal number of lines.

namespace CompareTwoTextFiles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstFile = "firstFile.txt";
            string secondFile = "secondFile.txt";

            CompareLinesOfTwoTextFiles(firstFile, secondFile);
        }

        private static void CompareLinesOfTwoTextFiles(string firstFile, string secondFile)
        {
            using (StreamReader reader = new StreamReader(firstFile))
            {
                string lineFromFirstFile = reader.ReadLine();
                using (StreamReader readerTwo = new StreamReader(secondFile))
                {
                    int count = 1;
                    string lineFromsecondFile = readerTwo.ReadLine();

                    while (lineFromFirstFile != null)
                    {
                        // compare lenght of the two lines
                        if (lineFromFirstFile.Length == lineFromsecondFile.Length)
                        {
                            for (int i = 0; i < lineFromFirstFile.Length; i++)
                            {
                                if (lineFromFirstFile[i] != lineFromsecondFile[i])
                                {
                                    Console.WriteLine("Line {0} from first file is equal to line {0} from second file -> {1}",
                                        count, false);
                                    break;
                                }
                                    // if all 'for' cicle is iterate and all chars are equal
                                else if (i == lineFromFirstFile.Length - 1)
                                {
                                    Console.WriteLine("Line {0} from first file is equal to line {0} from second file -> {1}",
                                        count, true);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Line {0} from first file is equal to line {0} from second file -> {1}",
                                        count, false);
                        }

                        count++;
                        lineFromFirstFile = reader.ReadLine();
                        lineFromsecondFile = readerTwo.ReadLine();
                    }
                }
            }
        }
    }
}
