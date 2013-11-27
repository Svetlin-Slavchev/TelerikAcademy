using mySolution;
using System;

namespace OOPmySolution
{
    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }
}
