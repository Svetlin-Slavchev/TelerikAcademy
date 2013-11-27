using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that extracts from a given text all sentences containing given word.
// Example: The word is "in".

class AllSentences
{
    static List<string> myList = new List<string>();
    static void Main(string[] args)
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        int index = text.IndexOf(".");
        string sentence = text.Substring(0, index + 1);
        int myIndex = index;
        myList.Add(sentence);
        
        while (true)
        {
            index = text.IndexOf(".", index + 1);
            if (index == -1)
            {
                break;
            }
            sentence = text.Substring(myIndex + 2, index - myIndex - 1);
            myIndex = index;
            myList.Add(sentence);
        }

        string word = "in";

        Console.WriteLine("String \"{0}\" contains in follow sectences:", word);
        Console.WriteLine();
        for (int i = 0; i < myList.Count; i++)
        {
            int indexTwo = myList[i].IndexOf("in");
            if (indexTwo <= myList[i].Length)
            {
                Console.WriteLine(myList[i]);
            }
            else
            {
                continue;
            }
        }
    }
}
