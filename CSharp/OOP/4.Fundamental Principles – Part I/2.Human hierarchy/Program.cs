using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define abstract class Human with first name and last name. Define new class Student which is derived from Human 
// and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
// and method MoneyPerHour() that returns money earned by hour by the worker. 
// Define the proper constructors and properties for this hierarchy.

namespace _2.Human_hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
            List<Student> students = new List<Student>()
            {
            new Student("Pesho", "Petrov", "grade II"),
            new Student("Plamen", "Nikilov", "grade I"),
            new Student("Niki", "Ivanov", "grade IV"),
            new Student("Svetla", "Rainova", "grade I"),
            new Student("Asen", "Georgiev", "grade II"),
            new Student("Mitko", "Slavchev", "grade V"),
            new Student("Georgi", "Naidenov", "grade I"),
            new Student("Polina", "Kamenova", "grade IV"),
            new Student("Mariq", "Petrova", "grade III"),
            new Student("Svetlio", "Gospodinov", "grade III"),
            };

            // lamda
            var sorted = students.OrderBy(x => x.Grade);

            // Linq
            var sorted2 =
                from s in students
                orderby s.Grade
                select s;

            Console.WriteLine("With lamda");
            Print(sorted);
            Console.WriteLine("\nLinq");
            Print(sorted2);

            // Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Pesho", "Plamenov", 102.5, 8),
                new Worker("Plamen", "Nikolov", 90, 8),
                new Worker("Nikola", "Asparuhov", 70, 8),
                new Worker("Eva", "Cenova", 200, 8),
                new Worker("Dragan", "Draganov", 150, 8),
                new Worker("Milan", "Mlanov", 120, 8),
                new Worker("Nataliq", "Boikova", 240, 8),
                new Worker("Asparuh", "Nikodimov", 80, 8),
                new Worker("Aleksandra", "Simeonova", 190, 8),
            };

            // lamda
            var sortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());

            // Linq
            var sortedWorkers2 =
                from w in workers
                orderby w.MoneyPerHour() descending
                select w;

            Console.WriteLine("\nWith lamda");
            Print(sortedWorkers);
            Console.WriteLine("\nLinq");
            Print(sortedWorkers2);

            // Merge the lists and sort them by first name and last name.
            List<Human> people = new List<Human>();
            people.AddRange(students);
            people.AddRange(workers);

            // lamda
            var sortedPeople = people.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            // Linq
            var sortedPeople2 =
                from p in people
                orderby p.FirstName, p.LastName
                select p;

            Console.WriteLine("\nWith lamda");
            Print(sortedPeople);
            Console.WriteLine("\nLinq");
            Print(sortedPeople2);
        }

        private static void Print(IEnumerable<Object> sorted)
        {
            foreach (var item in sorted)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
