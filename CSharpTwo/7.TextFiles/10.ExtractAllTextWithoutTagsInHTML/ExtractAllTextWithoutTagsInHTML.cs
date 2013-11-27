using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Write a program that extracts from given XML file all the text without the tags.

class ExtractAllTextWithoutTagsInHTML
{
    static List<string> myList = new List<string>();

    static void Main()
    {
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            Console.WriteLine("File before starting the program:");
            Console.WriteLine(reader.ReadToEnd());
            Console.WriteLine();
        }

        using (StreamReader reader = new StreamReader("text.txt"))
        {
            string allText = reader.ReadToEnd();
            int indexTwo = allText.IndexOf("<");
            int index = allText.IndexOf(">");

            while (true)
            {
                // start text with <
                if (indexTwo == 0)
                {
                    indexTwo = allText.IndexOf("<", indexTwo + 1);
                }
                // this means >< and continue searching
                while (index - indexTwo == -1)
                {
                    index = allText.IndexOf(">", index + 1);
                    indexTwo = allText.IndexOf("<", indexTwo + 1);
                }
                // end of cycle
                if (indexTwo == -1)
                {
                    break;
                }
                // extract substring
                string word = allText.Substring(index + 1, indexTwo - index - 1);
                // save in List
                myList.Add(word);
                // continue searching
                index = allText.IndexOf(">", index + 1);
                indexTwo = allText.IndexOf("<", indexTwo + 1);
            }
        }

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
    }
}
