using System;
using System.Linq;

namespace SortingStudentsAboutAge
{
    // Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

    class Program
    {
        static void Main(string[] args)
        {
            // use anonymous type
            var studets = new[] 
            { new { firstName = "Pesho", secondName = "Petrov", age = 18 },
              new { firstName = "Niki", secondName = "Malinov", age = 25 },
              new { firstName = "Bobi", secondName = "Petrov", age = 21 }  
            };

            var sortedStudents =
                from s in studets
                // compare by age
                where s.age >= 18 && s.age <= 24
                select s.firstName + " " + s.secondName;

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
            }
        }
    }
}
