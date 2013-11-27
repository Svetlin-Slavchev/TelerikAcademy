using System;

namespace Task2_DefineClasses_HumanStudentWorker
{
    public class Student : Human
    {
        private string grade;

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student()
        {
        }

        public Student(string firstName, string lastName)
            : base (firstName, lastName)
        {
        }

        public Student(string firstName, string lastName, string grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
