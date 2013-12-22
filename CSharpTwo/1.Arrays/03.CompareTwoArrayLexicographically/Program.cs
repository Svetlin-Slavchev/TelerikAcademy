using System;

// Write a program that compares two char arrays lexicographically (letter by letter).

namespace CompareTwoArrayLexicographically
{
    public class Program
    {
        static void Main()
        {
            char[] firstArr = {
                                     'a',
                                     'b',
                                     'n'
                                 };

            char[] secondArr = {
                                     'a',
                                     't',
                                     'y',
                                     'y'
                                 };

            int minLenght = Math.Min(firstArr.Length, firstArr.Length);

            for (int i = 0; i < minLenght; i++)
            {
                if (firstArr[i].CompareTo(secondArr[i]) == 0)
                {
                    Console.WriteLine("{0} = {1}", firstArr[i], secondArr[i]);
                }
                else if (firstArr[i].CompareTo(secondArr[i]) > 0)
                {
                    Console.WriteLine("{0} > {1}", firstArr[i], secondArr[i]);
                }
                else 
                {
                    Console.WriteLine("{0} < {1}", firstArr[i], secondArr[i]);
                }
            }
        }
    }
}
