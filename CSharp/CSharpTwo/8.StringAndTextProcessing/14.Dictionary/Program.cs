using System;

// A dictionary is stored as a sequence of text lines containing words and their explanations. 
// Write a program that enters a word and translates it by using the dictionary. 
// Sample dictionary:
// .NET – platform for applications from Microsoft
// CLR – managed execution environment for .NET
// namespace – hierarchical organization of classes
namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please, enter one of following words: .NET / CLR / namespace.");
                // string input = Console.ReadLine();
                string input = "CLR";

                if (input != ".NET" && input != "CLR" && input != "namespace")
                {
                    throw new ArgumentException();
                }

                switch (input)
                {
                    case ".NET": Console.WriteLine(".NET - platform for applications from Microsoft"); break;
                    case "CLR": Console.WriteLine("CLR - managed execution environment for .NET"); break;
                    case "namespace": Console.WriteLine("namespacehierarchical organization of classes"); break;
                    default:
                        break;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wrong input!");
            }
            catch (Exception)
            {
                Console.WriteLine("There is a error with the program. Try again!");
            }
        }
    }
}
