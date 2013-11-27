using System;
using System.IO;
using System.Linq;

// Write a program that compares two text files line by line and prints the number of lines
// that are the same and the number of lines that are different. Assume the files have equal number of lines.

class CompareTwoTextFiles
{
    static void Main(string[] args)
    {
        using (StreamReader reader = new StreamReader("firstFile.txt"))
        {
            string firstFileLine = reader.ReadLine();
            int countLines = 0;
            using (StreamReader secondReader = new StreamReader("secondFile.txt"))
            {
                string secondFileLine = secondReader.ReadLine();

                while ((firstFileLine != null) || (secondFileLine != null))
                {
                    countLines++;
                    if (firstFileLine.Equals(secondFileLine) == true)
                    {
                        Console.WriteLine("Line {0} with line {0} from this files are equal!", countLines); 
                    }
                    else
                    {
                        Console.WriteLine("Line {0} with line {0} from this files are Not equal!", countLines); 
                    }

                    firstFileLine = reader.ReadLine();
                    secondFileLine = secondReader.ReadLine();
                }
            }
        }
    }
}
