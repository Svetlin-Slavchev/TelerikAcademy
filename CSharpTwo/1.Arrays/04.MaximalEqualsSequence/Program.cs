using System;
using System.Collections.Generic;
using System.Text;

// Write a program that finds the maximal sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

namespace MaximalEqualsSequence
{
    public class Program
    {
        // method for separate sequences from array
        public static List<string> GetSequence(int startSequence, int endSequence, List<string> sequenceList, int count)
        {
            // StringBuilder is a class from type string. You may use also string = "",
            // and concat strings, but this is slow. 
            StringBuilder sb = new StringBuilder();
            sb.Append("( ");
            for (int j = 1; j <= count; j++)
            {
                sb.AppendFormat("{0} ", startSequence);
            }
            sb.Append(")");
            // save sequence in List
            sequenceList.Add(sb.ToString());
            // clear all variables to search new sequence
            startSequence = 0;
            endSequence = 0;
            count = 1;

            return sequenceList;
        }
        static void Main()
        {
            int count = 1;
            int startSequence = 0;
            int endSequence = 0;
            List<string> sequenceList = new List<string>();

            int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1] && startSequence == 0)
                {
                    // mark start of sequence
                    startSequence += arr[i];
                    count++;
                }
                // check for sequence in last 2 elements in array
                else if (arr[i] == arr[i + 1] && startSequence == 0 && i == arr.Length - 2)
                {
                    startSequence = arr[i];
                    endSequence = arr[i + 1];
                    count++;
                    GetSequence(startSequence, endSequence, sequenceList, count);
                    // clear all variables to search new sequence
                    startSequence = 0;
                    endSequence = 0;
                    count = 1;
                }
                // check the last element(if it is a part of sequence)
                else if (arr[i] == arr[i + 1] && i == arr.Length - 2)
                {
                    endSequence = arr[i + 1];
                    count++;
                    GetSequence(startSequence, endSequence, sequenceList, count);
                    // clear all variables to search new sequence
                    startSequence = 0;
                    endSequence = 0;
                    count = 1;
                }
                else if (arr[i]  == arr[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > 1)
                    {
                        // mark the end of the sequence
                        endSequence += arr[i];
                        GetSequence(startSequence, endSequence, sequenceList, count);
                        // clear all variables to search new sequence
                        startSequence = 0;
                        endSequence = 0;
                        count = 1;
                    }
                }
            }

            // mark the best sequence/s
            int bestLenght = 0;
            for (int i = 0; i < sequenceList.Count; i++)
            {
                if (bestLenght < sequenceList[i].Length)
                {
                    bestLenght = sequenceList[i].Length;
                }
            }

            // print result
            for (int i = 0; i < sequenceList.Count; i++)
            {
                if (bestLenght == sequenceList[i].Length)
                {
                    Console.WriteLine(sequenceList[i]);
                }
            }
        }
    }
}
