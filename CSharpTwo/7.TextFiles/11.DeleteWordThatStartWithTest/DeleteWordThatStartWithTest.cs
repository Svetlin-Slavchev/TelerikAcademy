using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

// Write a program that deletes from a text file all words that start with the prefix "test".
// Words contain only the symbols 0...9, a...z, A…Z, _.

class DeleteWordThatStartWithTest
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            Console.WriteLine("File before starting the program:");
            Console.WriteLine(reader.ReadToEnd());
            Console.WriteLine();
        }

        Console.WriteLine("File after starting the program:");
        using (StreamReader reader = new StreamReader("text.txt"))
        {
            string text = reader.ReadToEnd();
            // regex patten explanation: 
            // " " - spacebar before the "test"
            // test - our substring at the beginning of the word
            // [\w] - words contain only the symbols 0...9, a...z, A…Z, _
            // * - may contain more symbol after "test"
            string pattern = @" test[\w]*";

            Regex reg = new Regex(pattern);
            string newText = reg.Replace(text, "");
            Console.WriteLine(newText);
        }
    }
}
