using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

class ExtractFromHTML
{
    static List<string> myList = new List<string>();

    static void Main(string[] args)
    {
        string allText = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";

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

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
    }
}
