using System;

namespace Task1_DefineClasses
{
    public class Teacher : People
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Constructors
        public Teacher()
        {
        }

        public Teacher(string name)
        {
            this.Name = name;
        }
    }
}
