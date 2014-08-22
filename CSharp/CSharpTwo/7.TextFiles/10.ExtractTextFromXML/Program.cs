using System;
using System.Collections.Generic;

// Write a program that extracts from given XML file all the text without the tags. 
// Example:
// <?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>
// Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>

namespace ExtractTextFromXML
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = @"<?xml version=""1.0""><student><name>Pesho</name><age>21</age><interests count=""3""><interest>" + 
                        "Games</instrest><interest>C#</instrest><interest>Java</instrest></interests></student>";

            List<string> words = new List<string>();

            ExtractWords(text, words);
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
