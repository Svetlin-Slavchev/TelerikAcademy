using System;
using System.Collections.Generic;
using System.Linq;

// Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
// sum, product, min, max, average.

namespace IEnumerable
{
    public static class ExtentionForIEnumerable
    {
        public static T Sum<T>(this IEnumerable<T> enumeration)
        {  
            dynamic result = default(T);
            foreach (var item in enumeration)
            {
                result += item;
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            dynamic minElement = enumeration.ElementAt(0);
            foreach (var item in enumeration)
            {
                if (item.CompareTo(minElement) < 0)
                {
                    minElement = item;
                }
            }
            return minElement;
        }

        public static T Max<T>(this IEnumerable<T> enumeration) where T : IComparable
        {
            dynamic maxElement = enumeration.ElementAt(0);
            foreach (var item in enumeration)
            {
                if (item.CompareTo(maxElement) > 0)
                {
                    maxElement = item;
                }
            }
            return maxElement;
        }

        public static T Product<T>(this IEnumerable<T> enumeration)
        {
            dynamic sum = 1;
            foreach (var item in enumeration)
            {
                sum *= item;
            }

            return sum;
        }

        public static T Average<T>(this IEnumerable<T> enumeration)
        {
            dynamic sum = 0;
            dynamic count = 0;
            foreach (var item in enumeration)
            {
                sum += item;
                count++;
            }

            return sum / count;
        }
    }
}
