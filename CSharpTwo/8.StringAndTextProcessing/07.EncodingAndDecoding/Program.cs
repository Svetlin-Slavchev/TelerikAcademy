using System;
using System.Text;

// Write a program that encodes and decodes a string using given encryption key (cipher). 
// The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
// operation over the first letter of the string with the first of the key, the second – with the second, etc. 
// When the last key character is reached, the next is the first.

namespace EncodingAndDecoding
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text = "Write a program that encodes and decodes a string using given encryption key (cipher).";
            string key = "ab45d";

            // encode text
            string encryptedText = Encode(text, key);
            // decode encoding text
            string oldText = Decode(encryptedText, key);
            // print original text
            Console.WriteLine(oldText);
        }

        private static string Encode(string text, string key)
        {
            var encrypted = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                encrypted.Append((char)(text[i] ^ key[i % key.Length]));
            }

            return encrypted.ToString();
        }

        private static string Decode(string encryptedText, string key)
        {
            return Encode(encryptedText, key);
        }
    }
}
