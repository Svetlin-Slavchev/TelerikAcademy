using System;
using System.Linq;

// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.

class ConvertStringToUnicode
{
    static void Main(string[] args)
    {
        string word = "Hi!";
        Console.WriteLine("This text in Unicode symbols is: ");
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write("\\u{0:x4}", (int)word[i]);
        }
        
        Console.WriteLine();
    }
}
