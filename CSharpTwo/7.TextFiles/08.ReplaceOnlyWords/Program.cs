using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

// Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
// Ensure it will work with large files (e.g. 100 MB).

class ReplacesAllOccurrences
{
    static int index;

    static void Main(string[] args)
    {
        Console.WriteLine("In the begining file looks like this:");
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            Console.WriteLine(reader.ReadToEnd());
        }

        using (StreamReader reader = new StreamReader("text.txt"))
        {
            string line = reader.ReadLine();
            // using Regex
            string pattern = @"\b(start)\b";
            Regex myReg = new Regex(pattern);

            while (line != null)
            {
                line = myReg.Replace(line, "finish");
                line = reader.ReadLine();
            }
        }

        Console.WriteLine();
        Console.WriteLine("After running program the file is: ");
        using (StreamReader reader = new StreamReader("secondFile.txt"))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}

