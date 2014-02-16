using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School_hierarchy
{
    public class ClassInSchool : School
    {
        private List<Teacher> teachersSet;

        public ClassInSchool(string uniqueTextNumber, List<Teacher> teachers)
        {
            this.Name = uniqueTextNumber;
            this.teachersSet = new List<Teacher>();
        }

        public string UniqueTextNumber
        {
            get { return this.Name; }
        }   
    }
}
