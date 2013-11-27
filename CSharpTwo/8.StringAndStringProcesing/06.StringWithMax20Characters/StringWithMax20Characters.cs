using System;
using System.Linq;

// Write a program that reads from the console a string of maximum 20 characters.
// If the length of the string is less than 20, the rest of the characters should be filled with '*'.
// Print the result string into the console.

class StringWithMax20Characters
{
    static void Main(string[] args)
    {
        string word = "Alabala";
        Console.WriteLine(word.PadLeft(20, '*'));
    }
}
