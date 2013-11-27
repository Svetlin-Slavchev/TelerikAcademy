using System;
using System.Linq;

// You are given a text. Write a program that changes the text in
// all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested.

class ChangeToUppercase
{
    static void Main(string[] args)
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine("Old text is :");
        Console.WriteLine(text);
        Console.WriteLine();
        int index = text.IndexOf("<");
        index = text.IndexOf("<", index + 1);
        int indexTwo = text.IndexOf(">");
        int count = 1;
        int countTwo = 0;

        while (index != -1)
        {
            count++;
            countTwo++;
            if (count % 2 == 0)
            {
                string word = text.Substring(indexTwo + 1, (index) - (indexTwo + 1));
                string upperWord = word.ToUpper();
                text = text.Remove(indexTwo + 1, (index) - (indexTwo + 1));
                text = text.Insert(indexTwo + 1, upperWord);
            }
            index = text.IndexOf("<", index + 1);
            indexTwo = text.IndexOf(">", indexTwo + 1);
        }

        string textTwo = text.Replace("<upcase>", "");
        string textThree = textTwo.Replace("</upcase>.", ".");
        string textFour = textTwo.Replace("</upcase>", "");
        Console.WriteLine("New text is :");
        Console.WriteLine(textFour);
    }
}
