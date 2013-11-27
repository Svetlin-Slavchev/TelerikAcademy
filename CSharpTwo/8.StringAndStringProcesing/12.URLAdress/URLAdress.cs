using System;
using System.Linq;

// Write a program that parses an URL address given in the format:[protocol]://[server]/[resourse]
// and extracts from it the [protocol], [server] and [resource] elements.
// For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//	[protocol] = "http"
//	[server] = "www.devbg.org"
//	[resource] = "/forum/index.php"

class URLAdress
{
    static void Main(string[] args)
    {
        string adress = "http://www.devbg.org/forum/index.php";
        //string adress = "http://www.devbg.org";
        int index = adress.IndexOf("//");
        int indexTwo = adress.IndexOf("/");
        indexTwo = adress.IndexOf("/", indexTwo + 2);

        string protocol = adress.Substring(0, index - 1);
        Console.WriteLine(protocol);

        // if resourse is not found!
        if (indexTwo == -1)
        {
            string serverTwo = adress.Substring(index + 2, adress.Length - index - 2);
            Console.WriteLine(serverTwo);
        }
        else
        {
            string server = adress.Substring(index + 2, indexTwo - index - 2);
            Console.WriteLine(server);

            string resourse = adress.Substring(indexTwo, adress.Length - indexTwo);
            Console.WriteLine(resourse);
        }
    }
}