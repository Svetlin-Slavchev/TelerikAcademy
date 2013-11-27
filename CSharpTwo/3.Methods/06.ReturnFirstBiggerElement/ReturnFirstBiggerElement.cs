using System;
using System.Linq;

//Write a method that returns the index of the first element in array that is bigger than its neighbors,
//or -1, if there’s no such element.

class ReturnFirstBiggerElement
{
    static void Main(string[] args)
    {
        int[] array = { 1, 3, 4, 5, 9, 3, 4, 5 };
        int bigestNumber = FindBiggerThanNeigborsInArray(array);
        PrintResult(bigestNumber);
    }

    static int FindBiggerThanNeigborsInArray(int[] array)
    {
        int bigNumber = int.MinValue;
        int bigestNumber = int.MinValue;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (i == 0)
            {
                if (array[i] > array[i + 1])
                {
                    bigNumber = i;
                }
            }
            else if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                bigNumber = i;
                if (bigNumber > bigestNumber)
                {
                    bigestNumber = bigNumber;
                }
            }
        }
        return bigestNumber;
    }

    static void PrintResult(int bigestNumber)
    {
        if (bigestNumber == int.MinValue)
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine("The biggest number in this array is number with index {0}.", bigestNumber);
        }
    }
}

