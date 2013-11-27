using System;

namespace Task4_ClassPerson
{
    class Person
    {
        private string name;
        private int? age;

        public int? Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Person()
        {
        }

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            if (this.Age == null)
            {
                return string.Format("Name - {0} and there is no age!", this.Name);
            }
            return string.Format("Name - {0} and age - {1}.", this.Name, this.Age);
        }
    }
}
