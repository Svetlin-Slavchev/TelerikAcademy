using System;
using System.IO;
using System.Linq;
using System.Net;

// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
// and stores it the current directory. Find in Google how to download files in C#.
// Be sure to catch all exceptions and to free any used resources in the finally block.

class DownloadFileFromInternet
{
    static void Main(string[] args)
    {
        try
        {
            DownloadFile();
        }
        catch (WebException)
        {
            Console.WriteLine("There is some mistake! Try again later!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("There is some mistake! Try again later!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("There is some mistake! Try again later!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (Exception)
        {
            Console.WriteLine("There is some mistake! Try again later!");
        }
    }

    static void DownloadFile()
    { 
        using (WebClient client = new WebClient())
        {
            client.DownloadFile("http://code.google.com/intl/bg/", "Download.txt");
        }
        // Checking that program works
        StreamReader reader = new StreamReader("Download.txt");

        using (reader)
        {
            string allText = reader.ReadToEnd();
            Console.WriteLine(allText);
        }
    }
}
