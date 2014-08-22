using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School_hierarchy
{
    public abstract class School
    {
        private string name;
        private string comment;

        public School()
        { }

        public School(string name)
            : this (name, null)
        { }

        public School(string name, string comment)
        {
            this.Name = name;
            this.Comment = comment;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
    }
}
