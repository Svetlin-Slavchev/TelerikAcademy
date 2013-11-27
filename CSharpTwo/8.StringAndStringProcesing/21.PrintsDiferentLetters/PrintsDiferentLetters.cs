using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that reads a string from the console and prints all different letters
// in the string along with information how many times each letter is found.

class PrintsDiferentLetters
{
    static List<string> myList = new List<string>();

    static void Main(string[] args)
    {
        string word = "alabala";
        int count = 0;
        myList.Add("The letters is:");

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < word.Length; j++)
            {
                if (word[i] == word[j])
                {
                    count++;
                }
            }

            string str = "Letter " + word[i] + " - " + count + " times";
            for (int k = 0; k < myList.Count; k++)
            {
                if (str == myList[k])
                {
                    break;
                }
                if ((k == myList.Count - 1) && (str != myList[myList.Count - 1]))
                {
                    myList.Add(str);
                    break;
                }
            }
            count = 0;
        }

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
    }
}
