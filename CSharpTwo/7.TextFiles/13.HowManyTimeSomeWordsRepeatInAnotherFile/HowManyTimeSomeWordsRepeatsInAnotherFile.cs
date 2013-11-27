using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class HowManyTimeSomeWordsRepeatsInAnotherFile
{
    static List<string> myList = new List<string>();
    static List<int> mySecondList = new List<int>();
    static List<string> myThirtList = new List<string>();
    static int count = 0;

    static void Main(string[] args)
    {
        try
        {
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                Console.WriteLine("File before starting the program:");
                Console.WriteLine(reader.ReadToEnd());
                Console.WriteLine();
            }

            using (StreamReader reader = new StreamReader("words.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    myList.Add(line);
                    line = reader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader("test.txt"))
            {
                string allText = reader.ReadToEnd();
                for (int i = 0; i < myList.Count; i++)
                {
                    int index = allText.IndexOf(myList[i]);
                    while (true)
                    {
                        if (index == -1)
                        {
                            break;
                        }
                        count++;
                        index = allText.IndexOf(myList[0], index + 1);
                    }
                    mySecondList.Add(count);
                    count = 0;

                }
            }

            using (StreamWriter writter = new StreamWriter("result.txt"))
            {
                for (int i = 0; i < mySecondList.Count; i++)
                {
                    myThirtList.Add(mySecondList[i] + " times - " + myList[i]);
                }

                myThirtList.Sort();

                for (int i = myThirtList.Count - 1; i >= 0; i--)
                {
                    writter.WriteLine(myThirtList[i]);
                }
            }

            using (StreamReader reader = new StreamReader("result.txt"))
            {
                Console.WriteLine("File after starting the program:");
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid input. Try again!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid input. Try again!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file you want to read is not found!");
        }
        catch (IOException)
        {
            Console.WriteLine("There is some mistake. Try again!");
        }
    }
}
