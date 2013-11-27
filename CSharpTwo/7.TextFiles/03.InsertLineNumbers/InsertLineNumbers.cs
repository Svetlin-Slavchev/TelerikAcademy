using System;
using System.IO;
using System.Linq;

// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

class InsertLineNumbers
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            string line = reader.ReadLine();
            int count = 0;
            using (StreamWriter writer = new StreamWriter("newtext.txt"))
            {
                while (line != null)
                {
                    count++;
                    writer.WriteLine("Line {0}: {1}", count, line);
                    line = reader.ReadLine();
                }
            }
        }

        // Only for testing
        using (StreamReader reader = new StreamReader("newtext.txt"))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
