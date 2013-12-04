using AcademyEcoSystemMySolution.Classes;
using AcademyEcoSystemMySolution.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcoSystemMySolution.NewClassesByMe
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        public const int boarBitesize = 2;

        public Boar(string name, Point location)
            : base(name, location, 4)
        {
            this.Size = 4;
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size++;
                return plant.GetEatenQuantity(boarBitesize);
            }

            return 0;
        }
    }
}
