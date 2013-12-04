using AcademyEcoSystemMySolution.Classes;
using AcademyEcoSystemMySolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcoSystemMySolution.NewClassesByMe
{
    public class Wolf : Animal, ICarnivore
    {           
        public Wolf(string name, Point location)
            : base(name, location, 4)
        {
            this.Size = 4;
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if ((animal.Size <= this.Size) || (animal.State == AnimalState.Sleeping))
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }
    }
}
