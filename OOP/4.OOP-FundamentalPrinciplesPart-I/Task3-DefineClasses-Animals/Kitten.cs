using System;

namespace Task3_DefineClasses_Animals
{
    public class Kitten : Cat
    {
        private const string sex = "Female";

        public string Sex
        {
            get { return sex; }
            private set { }
        }

         public Kitten(string name, int age, string sex)
            : base (name, age, null)
        {
            this.Sex = sex;
        }
    }
}
