using System;

//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

class QuickSort
{
    static void Main(string[] args)
    { 
       int[] unsorted = { 3, -2, 5, 0, 3, 7, -1 };

        Quicksort(unsorted, 0, unsorted.Length - 1);

        for (int i = 0; i < unsorted.Length; i++)   
        {
            Console.Write(unsorted[i] + " ");
        }

        Console.WriteLine();
    }

    public static void Quicksort(int[] elements, int left, int right)
    {
        int i = left, j = right;
       int middle = elements[(left + right) / 2];


        while (i <= j)
        {
            while (elements[i].CompareTo(middle) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(middle) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                int tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}

