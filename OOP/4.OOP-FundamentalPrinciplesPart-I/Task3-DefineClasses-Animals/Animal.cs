using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_DefineClasses_Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private string sex;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public Animal()
        {
        }

        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        // Impementation of the method in interface
        public void ProduseSound()
        {
            Console.WriteLine("some sound");
        }
    }
}
