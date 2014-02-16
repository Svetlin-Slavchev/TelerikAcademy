using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string sex)
            : base(name, age, sex)
        { }

        public void ProduceSound()
        {
            Console.WriteLine("bau");
        }
    }
}
