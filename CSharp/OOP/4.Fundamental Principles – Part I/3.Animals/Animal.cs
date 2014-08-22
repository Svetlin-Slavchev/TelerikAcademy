using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private string sex;

        public Animal(int age, string name)
            : this(name, age, null)
        { }

        public Animal(string name, int age, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public void ProduceSound()
        {
            Console.WriteLine("aa");
        }
    }
}
