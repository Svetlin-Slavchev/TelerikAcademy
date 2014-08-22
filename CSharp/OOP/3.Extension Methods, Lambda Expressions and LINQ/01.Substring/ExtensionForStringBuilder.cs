using System;
using System.Linq;
using System.Text;

// Implement an extension method Substring(int index, int length) for the class StringBuilder
// that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace Substring
{
    public static class ExtensionForStringBuilder
    {
        public static string Substring(this StringBuilder sb, int index, int lenght)
        {
            StringBuilder sb2 = new StringBuilder();
            for (int i = index; i < index + lenght; i++)
            {
                sb2.Append(sb[i]);
            }
            return sb2.ToString();
        }
    }
}
