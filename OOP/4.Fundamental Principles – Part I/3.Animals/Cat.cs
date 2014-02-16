using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age)
            : this(name, age, null)
        { }

        public Cat(string name, int age, string sex)
            : base(name, age, sex)
        { }

        public void ProduceSound()
        {
            Console.WriteLine("miau");
        }
    }
}
