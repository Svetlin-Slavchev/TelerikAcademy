using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School_hierarchy
{
    public class Teacher : School
    {
        private List<Discipline> disciplinesSet;

        public Teacher(string name)
            : base(name)
        {
            this.disciplinesSet = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplinesSet.Add(discipline);
        }

        public string ShowDiscipline()
        {
            var sb = new StringBuilder();
            sb.Append("Disciplines:");
            foreach (var item in this.disciplinesSet)
            {
                sb.Append("\n" + item.Name + " ");
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            return string.Format("teacher name: {0}", this.Name);
        }
    }
}
