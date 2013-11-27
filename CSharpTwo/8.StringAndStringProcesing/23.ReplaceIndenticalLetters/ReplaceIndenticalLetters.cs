using System;
using System.Linq;
using System.Text;

// Write a program that reads a string from the console and replaces all series of consecutive
// identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

class ReplaceIndenticalLetters
{
    static void Main(string[] args)
    {
        string word = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder newWord = new StringBuilder();
        newWord.Append(word[0]);
        
        for (int i = 1; i < word.Length; i++)
        {
            // if char is equal to previous , do nothing
            if (word[i - 1] == word[i])
            {
                continue;
            }
            // else append in StringBuilder
            else
            {
                newWord.Append(word[i]);
            }
        }

        Console.WriteLine(newWord);
    }
}
