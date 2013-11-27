using System;
using System.IO;
using System.Linq;

// Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
// reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
// Be sure to catch all possible exceptions and print user-friendly error messages.

class ReadFile
{
    static void Main(string[] args)
    {
        try
        {
            ReadSomeFile();
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid file!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid file!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("File directory not found!");   
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This file can not be opened!");
        }  
    }

    static void ReadSomeFile()
    {
        StreamReader reader = new StreamReader("test.txt");

        using (reader)
        {
            string allText = reader.ReadToEnd();
            Console.WriteLine(allText);
        }
    }
}
