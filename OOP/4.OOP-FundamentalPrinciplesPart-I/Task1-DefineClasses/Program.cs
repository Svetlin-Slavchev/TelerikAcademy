using System;

// We are given a school. In the school there are classes of students. Each class has a set of teachers.
// Each teacher teaches a set of disciplines. Students have name and unique class number.
// Classes have unique text identifier. Teachers have name. Disciplines have name,
// number of lectures and number of exercises. Both teachers and students are people.
// Students, classes, teachers and disciplines could have optional comments (free text block).
// Your task is to identify the classes (in terms of  OOP) and their attributes and operations,
// encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.

namespace Task1_DefineClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolClass myClass = new SchoolClass("some class");
            Teacher myTeacher = new Teacher("some name");
            Student myself = new Student("my name", 21);
            Disciplines myFavorite = new Disciplines("Math", 20, 10);

            Console.WriteLine("My class is {0}.", myClass.TextIdentifier);
            Console.WriteLine("My teacher's name is {0}.", myTeacher.Name);
            Console.WriteLine("My name is {0} and my class number is {1}.", myself.Name, myself.ClassNumber);
            Console.WriteLine("My favorite discipline is {0}, it have {1} lectures and {2} exercises.",
                myFavorite.Name, myFavorite.Lectures, myFavorite.Exercises);
        }
    }
}
