using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> myList = new GenericList<int>(4);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(55);
            myList.Add(6);
            myList.Add(7);
            myList.Add(8);
            myList.Add(9);
            myList.Add(10);

            Console.WriteLine("Element ot thirt position si {0}.", myList.AccsesAt(3));

            Console.Write("Element in the list is: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("7 is in position {0}.", myList.FindByValue(7));
         
            Console.WriteLine("The max number in list is {0}.", myList.Max<int>());
            Console.WriteLine("The minimal number in thee list is {0}.", myList.Min<int>());

            myList.RemoveAt(5);

            myList.Insert(1, 100);
            Console.Write("Element in the list is: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.Write(myList[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(myList.ToString()); // whit 7 zeros more because list capacity is 16 now

            myList.Clear();
        }
    }
}
