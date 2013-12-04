﻿using AcademyEcoSystemMySolution.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcoSystemMySolution.NewClassesByMe
{
    public class Zombie : Animal
    {
        public Zombie(string name, Point location)
            : base(name, location, 0)
        {
            this.Size = 0;
        }

        public override int GetMeatFromKillQuantity()
        {
            this.IsAlive = true;
            return 10;
        }
    }
}
