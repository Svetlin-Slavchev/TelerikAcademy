using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age)
        {
            this.Sex = "female";
        }
    }
}
