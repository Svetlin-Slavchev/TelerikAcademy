using System;
using System.Text;

// Find online more information about ASCII (American Standard Code for Information Interchange)
// and write a program that prints the entire ASCII table of characters on the console.

class ASCIITable
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i < 257; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}
