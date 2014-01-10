using System;
using System.Text;

// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace SortingWordsInAlphabeticalOrder
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Write a program that reads a list of words";
            Console.WriteLine("Text:\n{0}", text);

            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words);
            StringBuilder result = new StringBuilder();

            result.Append(words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                result.AppendFormat(" {0}", words[i]);
            }

            Console.WriteLine("\nResult:\n{0}", result.ToString());
        }
    }
}
