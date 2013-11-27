using System;
using System.Linq;

// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class LIstOfWords
{
    static void Main(string[] args)
    {
        string words = "in, blaa, off, file";
        string[] myArray = words.Split(new char[]{',', ' '}, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(myArray);
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine(myArray[i]);
        }
    }
}
