using System;

namespace Task2_DefineClasses_HumanStudentWorker
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Human()
        {
        }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
