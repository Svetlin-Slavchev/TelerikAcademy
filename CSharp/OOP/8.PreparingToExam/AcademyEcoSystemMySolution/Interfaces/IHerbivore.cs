﻿using AcademyEcoSystemMySolution.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcoSystemMySolution.Interfaces
{
    public interface IHerbivore
    {
        int EatPlant(Plant plant);
    }
}
