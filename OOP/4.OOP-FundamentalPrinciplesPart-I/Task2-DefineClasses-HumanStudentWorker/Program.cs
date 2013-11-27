using System;
using System.Collections.Generic;
using System.Linq;

// Define abstract class Human with first name and last name.
// Define new class Student which is derived from Human and has new field – grade.
// Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay
// and method MoneyPerHour() that returns money earned by hour by the worker.
// Define the proper constructors and properties for this hierarchy.
// Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
// Initialize a list of 10 workers and sort them by money per hour in descending order.
// Merge the lists and sort them by first name and last name.

namespace Task2_DefineClasses_HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
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

            var sortedStudents = students.OrderBy(x => x.Grade);

            Console.WriteLine("Sorted by student's grade:");
            foreach (var item in sortedStudents)
            {
                Console.WriteLine("{0} {1}, {2}.", item.FirstName, item.LastName, item.Grade);
            }
            Console.WriteLine();

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

            //foreach (var item in workers)
            //{
            //    Console.WriteLine("{0} {1}, week salary - {2}, work per day - {3}, money per hour - {4}."
            //        , item.FirstName, item.LastName, item.WeekSalary, item.WorkHoursPerDay, item.MoneyPerHour(item.WeekSalary, item.WorkHoursPerDay));
            //}
            //Console.WriteLine();

            var sortedWorkrs = workers.OrderByDescending(x => x.MoneyPerHour(x.WeekSalary, x.WorkHoursPerDay));

            Console.WriteLine("Sorted by worker's money per hour:");
            foreach (var item in sortedWorkrs)
            {
                Console.WriteLine("{0} {1}, money per hour - {2}."
                    , item.FirstName, item.LastName, item.MoneyPerHour(item.WeekSalary, item.WorkHoursPerDay));
            }
            Console.WriteLine();

            // Merge the lists 
            List<Human> allPeople= new List<Human>();
            allPeople.AddRange(students);
            allPeople.AddRange(workers);

            var sortedPeople = allPeople.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            Console.WriteLine("Sorted people by first and last name:");
            foreach (var item in sortedPeople)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
        }
    }
}
