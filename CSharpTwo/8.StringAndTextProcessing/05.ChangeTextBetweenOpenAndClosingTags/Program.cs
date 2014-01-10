using System;

// You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> // and </upcase> to uppercase. The tags cannot be nested. // Example://    We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.// The expected result:

//    We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace ChangeTextBetweenOpenAndClosingTags
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            Console.WriteLine("Text: \n{0}", text);

            // replace substrings in tags with upper substrings
            text = ReplaceSubstringToUpper(text);
            // clean text from tags
            text = RemoveTags(text);

            Console.WriteLine("\nAfter modify: \n{0}", text);
        }

        private static string RemoveTags(string text)
        {
            int indexOfFirstChar = text.IndexOf('<');
            int indexOfSecondChar = text.IndexOf('>');

            while (indexOfFirstChar != -1)
            {
                string willRemove = text.Substring(indexOfFirstChar, indexOfSecondChar - indexOfFirstChar + 1);
                text = text.Replace(willRemove, null);

                indexOfFirstChar = text.IndexOf('<', indexOfFirstChar + 1);
                indexOfSecondChar = text.IndexOf('>', indexOfSecondChar + 1);
            }
            return text;
        }

        private static string ReplaceSubstringToUpper(string text)
        {
            int indexOfFirstChar = text.IndexOf('<');
            indexOfFirstChar = text.IndexOf('<', indexOfFirstChar + 1);
            int indexOfSecondChar = text.IndexOf('>');

            int count = 1;

            while (indexOfFirstChar != -1)
            {
                if (count % 2 != 0)
                {
                    string sub = text.Substring(indexOfSecondChar + 1, indexOfFirstChar - indexOfSecondChar - 1);
                    string toUpper = sub.ToUpper();
                    text = text.Replace(sub, toUpper);
                }

                indexOfFirstChar = text.IndexOf('<', indexOfFirstChar + 1);
                indexOfSecondChar = text.IndexOf('>', indexOfSecondChar + 1);
                count++;
            }
            return text;
        }
    }
}
