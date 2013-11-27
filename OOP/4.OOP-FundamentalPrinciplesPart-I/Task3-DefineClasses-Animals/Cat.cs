using System;

namespace Task3_DefineClasses_Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string sex)
            : base (name, age, sex)
        {
        }

        public void ProduseSound()
        {
            Console.WriteLine("miau");
        }
    }
}
