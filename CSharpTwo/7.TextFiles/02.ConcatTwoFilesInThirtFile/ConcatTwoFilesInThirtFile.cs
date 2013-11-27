using System;
using System.IO;
using System.Linq;

// Write a program that concatenates two text files into another text file.

class ConcatTwoFilesInThirtFile
{
    static void Main(string[] args)
    {
        using (StreamReader firstFile = new StreamReader("firstFile.txt"))
        {
            string line = firstFile.ReadLine();
            using (StreamWriter writer = new StreamWriter("thirtFile.txt", true))
            {
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = firstFile.ReadLine();
                }
            }
        }

        using (StreamReader secondFile = new StreamReader("secondFile.txt"))
        {
            string line = secondFile.ReadLine();
            using (StreamWriter writer = new StreamWriter("thirtFile.txt", true))
            {
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = secondFile.ReadLine();
                }
            }
        }
        // only for testing the program
        using (StreamReader thirtFile = new StreamReader("thirtFile.txt"))
        {
            Console.WriteLine(thirtFile.ReadToEnd());
        }
         //This cleans "thirtFile.txt"
        using (StreamWriter writer = new StreamWriter("thirtFile.txt"))
        {
            writer.Flush();
        }
    }
}
