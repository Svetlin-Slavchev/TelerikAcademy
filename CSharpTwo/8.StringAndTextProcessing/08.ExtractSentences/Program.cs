using System;
using System.Collections.Generic;

// Write a program that extracts from a given text all sentences containing given word.
// Example: The word is "in". The text is:
// We are living in a yellow submarine. We don't have anything else. 
// Inside the submarine is very tight. 
// So we are drinking all the day. We will move out of it in 5 days.

// The expected result is:
// We are living in a yellow submarine.
// We will move out of it in 5 days.

// Consider that the sentences are separated by "." and the words – by non-letter symbols.

namespace ExtractSentences
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else." +
                " Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            List<string> sentencesList = new List<string>();
            // extract sentences in list
            ExtractSentences(text, sentencesList);
            // select sentences with word "in" and print it
            SelectedSentencesAndPrintResult(sentencesList);
        }

        private static void SelectedSentencesAndPrintResult(List<string> sentencesList)
        {
            for (int i = 0; i < sentencesList.Count; i++)
            {
                if (sentencesList[i].Contains(" in ") || sentencesList[i].Contains(" in.") || sentencesList[i].Contains(" In"))
                {
                    Console.WriteLine(sentencesList[i]);
                }
            }
        }

        private static void ExtractSentences(string text, List<string> sentencesList)
        {
            int startSentences = 0;
            int endSentences = text.IndexOf('.');

            while (endSentences != -1)
            {
                string sentences = text.Substring(startSentences, endSentences - startSentences + 1);
                sentencesList.Add(sentences);

                startSentences = endSentences + 2;
                endSentences = text.IndexOf('.', endSentences + 1);
            }
        }
    }
}
