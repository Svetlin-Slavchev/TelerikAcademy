using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School_hierarchy
{
    public class Discipline : School
    {
        private string numberOfLecture;
        private string numberOfExercise;

        public Discipline(string name)
            :base(name)
        { }

        public Discipline(string name, string numberOfLecture, string numberOfExercise)
            : base(name)
        {
            this.NumberOfLecture = numberOfLecture;
            this.NumberOfExercise = numberOfExercise;
        }

        public string NumberOfLecture
        {
            get { return numberOfLecture; }
            set { numberOfLecture = value; }
        }

        public string NumberOfExercise
        {
            get { return numberOfExercise; }
            set { numberOfExercise = value; }
        }
    }
}
