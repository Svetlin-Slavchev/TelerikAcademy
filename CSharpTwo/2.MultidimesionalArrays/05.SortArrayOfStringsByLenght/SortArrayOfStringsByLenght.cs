using System;
using System.Linq;

// You are given an array of strings. Write a method that sorts the array by the length of its elements 
// (the number of characters composing them).

class SortArrayOfStringsByLenght
{
    static void Main(string[] args)
    {
        string[] array = {"alabala", "ala", "bala", "portokala"};
        Console.WriteLine("The array before sort is: ");
        PrintSortArray(array);
        SortArrayByLenght(array);
        Console.WriteLine("The array after sort is: ");
        PrintSortArray(array);            
    }

    static string[] SortArrayByLenght(string[] array)
    {

        for (int j = 0; j < array.Length - 1; j++)
        {
            int minKey = j;
            string temp = "";

            for (int k = j + 1; k < array.Length; k++)
            {
                if (array[k].Length < array[minKey].Length)
                {
                    minKey = k;
                }
            }

            temp = array[minKey];
            array[minKey] = array[j];
            array[j] = temp;
        }
        return array;
    }

    static void PrintSortArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("array[{0}] = {1}", i, array[i]);
        }
    }
}

