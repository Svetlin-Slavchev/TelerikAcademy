using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

// Write a program that removes from a text file all words listed in given another text file.
// Handle all possible exceptions in your methods.

class RemoveWordFromOneFileInAnotherFile
{
    static List<string> myList = new List<string>();

    static void Main(string[] args)
    {
        try
        {
            using (StreamReader reader = new StreamReader("firstFile.txt"))
            {
                Console.WriteLine("File before starting the program:");
                Console.WriteLine(reader.ReadToEnd());
                Console.WriteLine();
            }

            Console.WriteLine("File after starting the program:");
            using (StreamReader reader = new StreamReader("firstFile.txt"))
            {
                using (StreamReader readerTwo = new StreamReader("secondFile.txt"))
                {
                    string line = readerTwo.ReadLine();
                    while (line != null)
                    {
                        myList.Add(" " + line);
                        line = readerTwo.ReadLine();
                    }
                }

                string text = reader.ReadToEnd();

                // regex patten explanation: 
                // \b - start word
                // ( word| word| word) - "|" means "or"
                // \b - end of word

                //string pattern = @"\b( file| all| in)\b";
                string pattern = "\\b(" + myList[0] + "|" + myList[1] + "|" + myList[2] + ")\\b";

                Regex reg = new Regex(pattern, RegexOptions.IgnoreCase);
                string newText = reg.Replace(text, "");
                Console.WriteLine(newText);
            }
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid data in files! Try again.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid data in files! Try again.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Can not find the file you are looking for!");
        }
        catch (IOException)
        {
            Console.WriteLine("There is some mistake! Try again.");
        }
    }
}
