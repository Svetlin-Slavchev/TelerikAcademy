using System;

namespace Task3_DefineClasses_Animals
{
    public class Tomcat : Cat
    {
        private const string sex = "Male";

        public string Sex
        {
            get { return sex; }
            private set { }
        }

         public Tomcat(string name, int age, string sex)
            : base (name, age, null)
        {
            this.Sex = sex;
        }
    }
}
