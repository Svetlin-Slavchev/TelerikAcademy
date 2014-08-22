using System;

// Write a program that reads two arrays from the console and compares them element by element.

namespace CompareTwoArrays
{
    public class Program
    {
        static void Main()
        {
            // task condition is -  program that reads two arrays from the console - there is implementation

            //int firstArrLenght = int.Parse(Console.ReadLine());
            //int secondArrLenght = int.Parse(Console.ReadLine());
            //string[] firstArr = new string[firstArrLenght];
            //for (int i = 0; i < firstArrLenght; i++)
            //{
            //   firstArr[i] = Console.ReadLine();
            //}

            //string[] secondArr = new string[secondArrLenght];
            //for (int i = 0; i < firstArrLenght; i++)
            //{
            //    secondArr[i] = Console.ReadLine();
            //}

            string[] firstArr = {
                                     "ala",
                                     "bala",
                                     "nica"
                                 };

            string[] secondArr = {
                                     "ala",
                                     "jmala",
                                     "piza"
                                 };

            // find array whit smaller lenght
            int minLenght = Math.Min(firstArr.Length, firstArr.Length);

            for (int i = 0; i < minLenght; i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
        }
    }
}
