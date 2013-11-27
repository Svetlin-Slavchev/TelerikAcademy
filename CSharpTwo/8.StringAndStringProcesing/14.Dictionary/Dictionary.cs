using System;
using System.IO;
using System.Linq;

// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.

class Dictionary
{
    static void Main(string[] args)
    {
        string word = Console.ReadLine();
        
        using (StreamReader reader = new StreamReader("dictionary.txt"))
        {
            // dictionary.txt - content:
            //.NET – platform for applications from Microsoft
            // CLR – managed execution environment for .NET
            // namespace – hierarchical organization of classes

            string line = reader.ReadLine();
            while (line != null)
            {
                int index = line.IndexOf(" ");
                string newWord = line.Substring(0, index);
                if (word == newWord)
                {
                    string explanation = line.Substring(index + 3);
                    Console.WriteLine(explanation);
                }

                line = reader.ReadLine();
            }
        }
    }
}
  

