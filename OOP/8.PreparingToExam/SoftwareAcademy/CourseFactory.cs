using OOPmySolution;
using System;

namespace mySolution
{
    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            ITeacher teacher = new Teacher();
            teacher.Name = name;
            return teacher;
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            ILocalCourse CreateLocalCourse = new LocalCourse();
            CreateLocalCourse.Name = name;
            CreateLocalCourse.Teacher = teacher;
            CreateLocalCourse.Lab = lab;
            return CreateLocalCourse;
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            IOffsiteCourse CreateOffsiteCourse = new OffsiteCourse();
            CreateOffsiteCourse.Name = name;
            CreateOffsiteCourse.Teacher = teacher;
            CreateOffsiteCourse.Town = town;
            return CreateOffsiteCourse;
        }
    }
}
