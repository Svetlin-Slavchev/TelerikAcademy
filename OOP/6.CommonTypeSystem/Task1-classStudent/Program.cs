using System;

// Define a class Student, which contains data about a student – first, middle and last name, SSN,
// permanent address, mobile phone e-mail, course, specialty, university, faculty.
// Use an enumeration for the specialties, universities and faculties.
// Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

namespace Task1_classStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FirstName = "Pesho";
            student.MiddleName = "Ivanov";
            student.LastName = "Petkov";
            student.University = University.SU;
            student.Specialty = Specialty.SoftwareEngineer;

            Console.WriteLine(student.ToString());
            Console.WriteLine(student.University);
            Console.WriteLine(student.Specialty);
            
        }
    }
}
