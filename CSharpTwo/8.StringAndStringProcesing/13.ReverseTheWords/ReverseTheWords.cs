using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Write a program that reverses the words in given sentence.
// Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

class ReverseTheWords
{
    static List<char> myList = new List<char>();

    static void Main(string[] args)
    { 
        string text = "C# is not C++, not PHP and not Delphi!";
        string[] myArray = text.Split(new char[]{' ', ',', '.', '!'}, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(myArray);
 
        for (int i = 0; i < text.Length; i++)
        {
            if ((char.IsPunctuation(text, i) == true) || (char.IsSeparator(text, i) == true))
            {
                myList.Add(text[i]);
            }
        }

        StringBuilder newText = new StringBuilder();
        for (int i = 0; i < myArray.Length; i++)
        {
            newText.Append(myArray[i]);
            newText.Append(myList[i + 1]);
        }

        newText.Remove(newText.Length - 1, 1);
        newText.Append('!');

        Console.WriteLine(newText);
    }
}
