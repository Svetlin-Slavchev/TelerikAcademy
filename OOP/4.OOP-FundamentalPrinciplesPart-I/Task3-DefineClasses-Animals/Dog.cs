using System;

namespace Task3_DefineClasses_Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string sex)
            : base (name, age, sex)
        {
        }

        public void ProduseSound()
        {
            Console.WriteLine("bauuu");
        }
    }
}
