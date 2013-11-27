using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Write a program that deletes from given text file all odd lines. The result should be in the same file.

class DeleteAllOddLines
{
    static List<string> myString = new List<string>();
    static int count = 0;
    
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                count++;
                // This is the odd lines
                if (count % 2 != 0)
                {
                    myString.Add(line);
                    line = reader.ReadLine();
                }
                else
                {
                    line = reader.ReadLine();
                }
            }
        }

        using (StreamWriter writter = new StreamWriter("text.txt", true))
        {
            for (int i = 0; i < myString.Count; i++)
            {
                // Write result in the same file
                writter.WriteLine("Line" + (i + 1) +  " " + myString[i]);
            }
        }
        // For testing!!!
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
