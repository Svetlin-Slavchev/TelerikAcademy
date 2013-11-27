using System;
using System.Linq;

// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name 
// and last name in descending order. Rewrite the same with LINQ.

namespace SortingStudentsInDescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var studets = new[] 
            { new { firstName = "Pesho", secondName = "Petrov" },
              new { firstName = "Pesho", secondName = "Malinov" },
              new { firstName = "Bobi", secondName = "Petrov" }  
            };

            // sorting whit Lamda expressions
            var sortedStudents = studets.OrderByDescending(s => s.firstName).ThenByDescending(s => s.secondName);

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // sorting whit LINQ
            var sortedStudentsWhitLINQ =
                from s in studets
                orderby s.firstName + s.secondName descending               
                select s;

            foreach (var item in sortedStudentsWhitLINQ)
            {
                Console.WriteLine(item);
            }
        }
    }
}
