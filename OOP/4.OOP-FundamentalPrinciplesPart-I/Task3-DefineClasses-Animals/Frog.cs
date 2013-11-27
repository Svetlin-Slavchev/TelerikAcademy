using System;

namespace Task3_DefineClasses_Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string sex)
            : base (name, age, sex)
        {
        }

        public void ProduseSound()
        {
            Console.WriteLine("krqkkk");
        }
    }
}
