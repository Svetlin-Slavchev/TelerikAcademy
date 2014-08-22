using OOPmySolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mySolution
{
    public class Teacher : ITeacher
    {
        List<ICourse> myCourse = new List<ICourse>();

        public string Name { get; set; }

        public void AddCourse(ICourse course)
        {           
            myCourse.Add(course);
        }

        public override string ToString()
        {
            if (myCourse.Count == 0)
            {
                return string.Format("Teacher: Name={0}", this.Name);
            }
            return string.Format("Teacher: Name={0}; Courses=[{1}]", this.Name, this.ReturnCurses(myCourse));
        }

        public string ReturnCurses(List<ICourse> myCourse)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var courses in myCourse)
            {
                sb.Append(courses.Name);
                sb.Append(", ");
            }
            sb.Remove(sb.Length - 2, 2);
            return sb.ToString();
        }
    }
}
