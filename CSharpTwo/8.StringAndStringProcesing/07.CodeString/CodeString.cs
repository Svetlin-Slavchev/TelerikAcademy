using System;
using System.Linq;
using System.Text;

// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
// operation over the first letter of the string with the first of the key, the second – with the second, etc.
// When the last key character is reached, the next is the first.

class CodeString
{

    static void Main()
    {
        string str = "Telerik Academy";
        string chiper = "12321";

        string resultEncoded = EncoderDecoder(str, chiper);
        Console.WriteLine(resultEncoded);
        string resultDecoded = EncoderDecoder(resultEncoded, chiper);
        Console.WriteLine(resultDecoded);
    }

    private static string EncoderDecoder(string str, string chiper)
    {
        StringBuilder myStr = new StringBuilder();

        for (int i = 0; i < str.Length; i += chiper.Length)
        {
            for (int j = 0; j < chiper.Length; j++)
            {
                if (i + j > str.Length - 1)
                {
                    break;
                }
                char temp = (char)(str[i + j] ^ chiper[j]);
                myStr.Append(temp);
            }
        }
        return myStr.ToString();
    }


}
