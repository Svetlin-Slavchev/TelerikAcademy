using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
// Example:
//	Ivan			George
//	Peter			Ivan
//	Maria			Maria
//	George			Peter

class ListOfNames
{
    static List<string> myList = new List<string>();
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("firstFile.txt"))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                myList.Add(line);
                // Only for testing!!!
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            Console.WriteLine();

            myList.Sort();
        }

        using (StreamWriter writer = new StreamWriter("secondFile.txt"))
        {
            for (int i = 0; i < myList.Count; i++)
            {
                writer.WriteLine(myList[i]);
            }
        }
        // Only for testing!!!
        using (StreamReader reader = new StreamReader("secondFile.txt"))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
