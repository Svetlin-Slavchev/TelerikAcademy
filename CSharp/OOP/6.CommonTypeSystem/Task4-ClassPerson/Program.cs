using System;

// Create a class Person with two fields – name and age.
// Age can be left unspecified (may contain null value.
// Override ToString() to display the information of a person and if age is not specified – to say so.
// Write a program to test this functionality.

namespace Task4_ClassPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person human = new Person();
            human.Name = "Pesho";
            human.Age = 24;
            Console.WriteLine(human.ToString());

            Person humanTwo = new Person("Niki", null);
            Console.WriteLine(humanTwo.ToString());
        }
    }
}
