using System;

// Write a program that reads a string, reverses it and prints the result at the console.

namespace ReverseString
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "alabalaPORTOKALA";
            // convert to array to use Array.Reverse() from Array class
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);

            Console.WriteLine(charArr);
        }
    }
}
