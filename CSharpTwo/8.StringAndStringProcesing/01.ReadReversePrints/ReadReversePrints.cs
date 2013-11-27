using System;
using System.Linq;

// Write a program that reads a string, reverses it and prints the result at the console.

class ReadReversePrints
{
    static void Main(string[] args)
    {
        string word = "alabalanica";
        Console.WriteLine("Reverse string is: ");
        for (int i = word.Length - 1; i >= 0 ; i--)
        {  
            Console.Write(word[i]);
        }

        Console.WriteLine(); 
    }
}
