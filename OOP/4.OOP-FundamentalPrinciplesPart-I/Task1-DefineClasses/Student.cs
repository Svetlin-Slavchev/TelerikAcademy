using System;

namespace Task1_DefineClasses
{
    public class Student : People
    {
        // Fields
        private string name;
        private int classNumber;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ClassNumber
        {
            get { return classNumber; }
            set { classNumber = value; }
        }

        // Constructors
        public Student()
        {
        }

        public Student(string name)
            : this(name, 0)
        {
        }

        public Student(string name, int classNumber)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }
    }
}
