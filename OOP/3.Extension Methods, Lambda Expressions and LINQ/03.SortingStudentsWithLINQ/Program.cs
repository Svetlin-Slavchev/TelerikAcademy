using System;
using System.Linq;

// Write a method that from a given array of students finds all students whose first name is before
// its last name alphabetically. Use LINQ query operators.

namespace SortingStudentsWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // use anonymous type
            var studets = new[] 
            { new { firstName = "Pesho", secondName = "Petrov" },
              new { firstName = "Niki", secondName = "Malinov" },
              new { firstName = "Bobi", secondName = "Petrov" }  
            };

            var sortedStudents =
                from s in studets
                // compare first letters from first and second names
                where s.firstName.Substring(0, 1).CompareTo(s.secondName.Substring(0, 1)) == -1
                select s;

            // print result
            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }
        }
    }
}
