using System;

// Write a program that reads two arrays from the console and compares them element by element.

class Compare2Arrays
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int k = int.Parse(Console.ReadLine());
        int[] secondArray = new int[k];

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < secondArray.Length; j++)
        {
            secondArray[j] = int.Parse(Console.ReadLine());
        }

        bool equals = true;
        for (int p = 0; p < n; p++)
        {    
           if (firstArray[p] != secondArray[p])
            {
                equals = false;
            }
            Console.WriteLine("element[{0}] = element[{0}] --> {1}", p, equals);
        } 
        Console.WriteLine(equals);
    }
}
