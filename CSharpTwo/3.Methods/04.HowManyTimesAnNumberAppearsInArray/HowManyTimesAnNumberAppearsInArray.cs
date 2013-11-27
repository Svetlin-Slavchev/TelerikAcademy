using System;
using System.Linq;

// Write a method that counts how many times given number appears in given array.
// Write a test program to check if the method is working correctly.

class HowManyTimesAnNumberAppearsInArray
{
    static void Main()
    {
        int[] array = { 1, 3, 4, 5, 8, 3, 4, 5 };
        int number = int.Parse(Console.ReadLine());
        AppearsNumber(array, number);
        int count = AppearsNumber(array, number);
        PrintResult(count, number);
    }

    static int AppearsNumber(int[] array, int number)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }
        return count;
    }

    static void PrintResult(int count, int number)
    {
        Console.WriteLine("The number {0} appears in this array {1} times!", number, count);
    }
}