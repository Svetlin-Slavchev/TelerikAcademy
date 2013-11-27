using System;

namespace Task1_DefineClasses
{
    public class Disciplines : SchoolClass
    {
        // Fields
        private string name;
        private int lectures;
        private int exercises;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Lectures
        {
            get { return lectures; }
            set { lectures = value; }
        }

        public int Exercises
        {
            get { return exercises; }
            set { exercises = value; }
        }

        // Constructors
        public Disciplines()
        {
        }

        public Disciplines(string name)
            : this(name, 0)
        {
        }

        public Disciplines(string name, int lectures)
            : this(name, lectures, 0)
        {
        }

        public Disciplines(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercises;
        }
    }
}
