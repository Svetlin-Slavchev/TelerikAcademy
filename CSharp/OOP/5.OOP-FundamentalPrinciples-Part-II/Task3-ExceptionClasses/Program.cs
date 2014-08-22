using System;
using System.Collections.Generic;

// Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
// It should hold error message and a range definition [start … end].
// Write a sample application that demonstrates the InvalidRangeException<int>
// and InvalidRangeException<DateTime> by entering numbers in the range [1..100]
// and dates in the range [1.1.1980 … 31.12.2013].

namespace Task3_ExceptionClasses
{
    class Program
    {
        // using generic method
        public static void ReadNumbers<T>(dynamic start, dynamic end) where T : IComparable<T>
        {
            while (true)
            {
                // if parameters is type int
                if (start is int)
                {
                    Random rand = new Random();
                    // generate random number for - 100 to 200
                    dynamic number = rand.Next(-100, 200);

                    if (number < start || number > end)
                    {
                        throw new InvalidRangeException<T>("The number must be in range 1 - 100!");
                    }
                }
                    // if parameters is type DateTime
                else if (start is DateTime)
                {
                    List<DateTime> list = new List<DateTime>();
                    list.Add(DateTime.Now);
                    list.Add(DateTime.MinValue);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] < start || list[i] > end)
                        {
                            throw new InvalidRangeException<T>("Date time must be in range 1.1.1980 - 31.12.2013!");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                // Unmark to test and mark DateTime

                // ReadNumbers<int>(1, 100);

                DateTime start = new DateTime(1980, 1, 1);
                DateTime end = new DateTime(2013, 12, 31);
                ReadNumbers<DateTime>(start, end);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("----------------------");
                Console.WriteLine(ex.StackTrace);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("----------------------");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
