using System;
using System.Collections.Generic;
using System.Linq;

// Write a program that reads a string from the console and lists all different words
// in the string along with information how many times each word is found.

class PrintDiferentWords
{
    static List<string> myList = new List<string>();

    static void Main(string[] args)
    {
        string text = "alabala portokala, alabala tralalala!";
        string[] myArray = text.Split(new char[]{' ', '!', ','}, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        myList.Add("The letters is:");

        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray.Length; j++)
            {
                if (myArray[i] == myArray[j])
                {
                    count++;
                }
            }

            string str = "Word " + myArray[i] + " - " + count + " times";
            for (int k = 0; k < myList.Count; k++)
            {
                if (str == myList[k])
                {
                    break;
                }
                if ((k == myList.Count - 1) && (str != myList[myList.Count - 1]))
                {
                    myList.Add(str);
                    break;
                }
            }
            count = 0;
        }

        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
    }
}
