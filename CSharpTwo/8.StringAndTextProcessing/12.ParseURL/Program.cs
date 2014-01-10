using System;

// Write a program that parses an URL address given in the format://      [protocol]://[server]/[resource]// and extracts from it the [protocol], [server] and [resource] elements. // For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:        // [protocol] = "http"        // [server] = "www.devbg.org"        // [resource] = "forum/index.php"

namespace ParseURL
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "http://www.devbg.org/forum/index.php";

            // extract protocol
            int indexColon = text.IndexOf(':');
            string protocol = text.Substring(0, indexColon);
            
            // extract server
            int indexSlash = text.IndexOf('/');
            indexSlash = text.IndexOf('/' , indexSlash + 2);
            string server = text.Substring(indexColon + 3, indexSlash - indexColon - 3);

            // extract resource
            string resource = text.Substring(indexSlash + 1, text.Length - indexSlash - 1);

            Console.WriteLine("{0}\n{1}\n{2}", protocol, server, resource);
        }
    }
}
