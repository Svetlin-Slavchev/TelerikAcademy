using System;
using System.Collections.Generic;

// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. 
// Example:
    // <html>
    //  <head><title>News</title></head>
    //  <body><p><a href="http://academy.telerik.com">Telerik
    //    Academy</a>aims to provide free real-world practical
    //    training for young people who want to turn into
    //    skillful .NET software engineers.</p></body>
    //</html>

namespace ExtractTitleFromHTML
{
   public class Program
    {
        static void Main(string[] args)
        {
            string allText = "<html><head><title>News</title></head><body><p>" +
                "<a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free" +
                "real-world practical training for young people who want to turn into skillful .NET software engineers.</p>" +
                "</body></html>";

            List<string> words = new List<string>();

            ExtractWords(allText, words);
            PrintResult(words);
        }

        private static void PrintResult(List<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine(words[i]);
            }
        }

        private static void ExtractWords(string text, List<string> words)
        {
            int firstChar = text.IndexOf('>');
            int secondChar = text.IndexOf('<');
            // we begin from second occurrence of '<'
            secondChar = text.IndexOf('<', secondChar + 1);

            while (secondChar != -1)
            {
                if (firstChar + 1 == secondChar)
                {/* do nothing */}
                else if (firstChar == text.Length - 1)
                {
                    break;
                }
                else
                {
                    string word = text.Substring(firstChar + 1, (secondChar - 1) - (firstChar));
                    words.Add(word);
                }

                firstChar = text.IndexOf('>', firstChar + 1);
                secondChar = text.IndexOf('<', secondChar + 1);
            }
        }
    }
}
