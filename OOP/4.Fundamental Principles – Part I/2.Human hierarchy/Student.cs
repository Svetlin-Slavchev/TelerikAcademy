using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Human_hierarchy
{
    public class Student : Human
    {
        private string grade;

        public Student(string firstName, string lastName, string grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public string Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
