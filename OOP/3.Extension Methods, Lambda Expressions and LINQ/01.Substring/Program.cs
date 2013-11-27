using System;
using System.Linq;
using System.Text;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ala bala");
            sb.Append(" ");
            sb.Append("nica");

            Console.WriteLine(sb.Substring(9, 4));
        }
    }
}
