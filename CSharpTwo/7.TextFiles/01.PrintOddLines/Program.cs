using System;
using System.IO;

// Write a program that reads a text file and prints on the console its odd lines.

namespace PrintOddLines
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string line = reader.ReadLine();
                int count = 1;
                while (line != null)
                {
                    if (count % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    count++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
