using System;

// Write a program that compares two char arrays lexicographically (letter by letter).

class Program    // This task includes the addition of the same task in the book.
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        char[] firstArray = new char[n];
        int k = int.Parse(Console.ReadLine());
        char[] secondArray = new char[k];

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        for (int j = 0; j < secondArray.Length; j++)
        {
            secondArray[j] = char.Parse(Console.ReadLine());
        }

        bool equals = true;

        int countF = 0;
        int countS = 0;

        for (int p = 0; p < n; p++)
        {

            if ((firstArray[p] != secondArray[p]) || (n != k))
            {
                equals = false;

                if (firstArray[p] > secondArray[p])
                {
                    countF++;
                }

                if (firstArray[p] < secondArray[p])
                {
                    countS++;
                }
            }
        }

        if (countF > countS)
        {
            Console.WriteLine("The least of arrays is secondArray!");
        }
        else
        {
            Console.WriteLine("The least of arrays is firstArray!");
        }

        Console.WriteLine(equals ? "This two arrays are equals!" : "This two arrays is not equals!");
    }
}

