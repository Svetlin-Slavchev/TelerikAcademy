using System;
using System.IO;
using System.Linq;

// Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
// Ensure it will work with large files (e.g. 100 MB).

class ReplacesAllOccurrences
{
    static void Main(string[] args)
    {
        Console.WriteLine("First file is:");
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            Console.WriteLine(reader.ReadToEnd());
        }

        using (StreamReader reader = new StreamReader("text.txt"))
        {
            string line = reader.ReadLine();
            using (StreamWriter writer = new StreamWriter("secondFile.txt"))
            {
                while (line != null)
                {
                    line = line.Replace("start", "finish");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }  
            }
        }

        Console.WriteLine();
        Console.WriteLine("Second file is: ");
        using (StreamReader reader = new StreamReader("secondFile.txt"))
        {
            Console.WriteLine(reader.ReadToEnd());
        }  
    }
}
