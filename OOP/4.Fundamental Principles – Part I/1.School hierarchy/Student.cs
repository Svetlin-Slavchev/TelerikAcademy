using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School_hierarchy
{
    public class Student : School
    {
        private string uniqueClassNumber;

        public Student(string name, string uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public string UniqueClassNumber
        {
            get { return uniqueClassNumber; }
            set { uniqueClassNumber = value; }
        }

        public override string ToString()
        {
            return string.Format("student name: {0}, class number: {1}", this.Name, this.UniqueClassNumber);
        }
    }
}
