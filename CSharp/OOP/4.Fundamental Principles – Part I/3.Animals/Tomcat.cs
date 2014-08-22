using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Animals
{
    public class Tomcat : Cat
    {
       public Tomcat(string name, int age)
            : base(name, age)
        {
            this.Sex = "male";
        }
    }
}
