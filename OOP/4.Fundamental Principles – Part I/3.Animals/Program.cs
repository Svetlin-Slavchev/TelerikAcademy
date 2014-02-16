using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
// Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
// Kittens and tomcats are cats. All animals are described by age, name and sex. 
// Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
// Create arrays of different kinds of animals and calculate the average age of each kind of animal 
// using a static method (you may use LINQ).

namespace _3.Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] myArr = {
                                 new Dog("Sharo", 10, "Male"),
                                 new Dog("Sara", 8, "Female"),
                                 new Dog("Asparuh", 7, "Male"),
                             };

            Animal[] myArrTwo = {
                                 new Frog("Frogi", 5, "Male"),
                                 new Dog("Sharo", 10, "Male"),
                                 new Tomcat("Tom", 8),
                                 new Kitten("Asparuhcho", 1),
                                 new Cat("Some cat", 5, "Male"),
                             };

            // Calculate average
            var averageInFirstArray = myArr.Average(x => x.Age);
            Console.WriteLine(averageInFirstArray);

            var averageInSecondArray = myArrTwo.Average(x => x.Age);
            Console.WriteLine(averageInSecondArray);

            Cat cat = new Cat("Some cat", 5, "Male");
            Dog dog = new Dog("Sharo", 10, "Male");
            cat.ProduceSound();
            dog.ProduceSound();
        }
    }
}
