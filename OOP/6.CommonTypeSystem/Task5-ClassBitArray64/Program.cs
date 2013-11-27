using System;

// Define a class BitArray64 to hold 64 bit values inside an ulong value.
// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace Task5_ClassBitArray64
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 number = new BitArray64(50);
            BitArray64 numberTwo = new BitArray64(2000);

            // foreach all bits in number
            foreach (var bits in number)
            {
                Console.Write(bits);
            }
            Console.WriteLine();

            Console.WriteLine(number.Equals(numberTwo));
            Console.WriteLine(number == numberTwo);          
        }
    }
}
