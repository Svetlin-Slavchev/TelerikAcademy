using System;

// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
// Prnt the obtained array on the console.

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[20];

        for (int index = 0; index < array.Length; index++)
        {
            array[index] = index * 5;
            Console.Write(array[index] + " ");
        }
    }
}
