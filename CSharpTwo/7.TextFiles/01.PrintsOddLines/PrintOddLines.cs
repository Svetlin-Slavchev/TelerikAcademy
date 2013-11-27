using System;
using System.IO;
using System.Linq;

// Write a program that reads a text file and prints on the console its odd lines.

class PrintOddLines
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            string line = reader.ReadLine();
            int count = 0;

            while (line != null)
            {
                count++;
                // This is the odd lines
                if (count % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", count, line);
                    line = reader.ReadLine();
                }
                else
                {
                    line = reader.ReadLine();
                }
            }
        }
    }
}
