using System;

namespace Task1_classStudent
{
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string permanentAdress;
        private int mobilePhone;
        private string email;
        private string course;
        private Faculty faculty;
        private Specialty specialty;
        private University university;

        // Properties
        public University University
        {
            get { return university; }
            set { university = value; }
        }

        public Specialty Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        public Faculty Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public string Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int MobilePhone
        {
            get { return mobilePhone; }
            set { mobilePhone = value; }
        }

        public string PermanentAdress
        {
            get { return permanentAdress; }
            set { permanentAdress = value; }
        }

        public int SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // overriding some methods and operators
        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            // If the cast is invalid, the result will be null
            if (student == null)
            {
                return false;
            }
            // Compare the reference type member fields
            else if (!Object.Equals(this.firstName, student.firstName))
            {
                return false;
            }
            // Compare the value type member fields
            else if (this.SSN != student.SSN)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("This student is {0} {1} {2}."
                , this.FirstName, this.MiddleName, this.LastName);
        }

        public static bool operator ==(Student studentOne, Student studentTwo)
        {
            return Student.Equals(studentOne, studentTwo);
        }

        public static bool operator !=(Student studentOne, Student studentTwo)
        {
            return !(Student.Equals(studentOne, studentTwo));
        }

        // Task 2
        // Add implementations of the ICloneable interface.
        // The Clone() method should deeply copy all object's fields into a new object of type Student.

        public object Clone()
        {
            var obj = new Student();
            obj.FirstName = (string)this.FirstName.Clone();
            obj.MiddleName = (string)this.MiddleName.Clone();
            obj.LastName = (string)this.LastName.Clone();
            obj.SSN = this.SSN;
            obj.PermanentAdress = (string)this.PermanentAdress.Clone();
            obj.MobilePhone = this.MobilePhone;
            obj.Email = (string)this.Email.Clone();
            obj.Course = (string)this.Course.Clone();
            obj.Faculty = this.Faculty;
            obj.Specialty = this.Specialty;
            obj.University = this.University;

            return obj;
        }

        // Task 3
        // Implement the IComparable<Student> interface to compare students by names
        // (as first criteria, in lexicographic order) and by social security number
        // (as second criteria, in increasing order).

        public int CompareTo(Student other)
        {
            // compare by name
            if (this.FirstName[0] > other.firstName[0])
            {
                return 1;
            }
            else if (this.FirstName[0] < other.firstName[0])
            {
                return -1;
            }
                // compare by social security number
            else 
            {
                if (this.SSN < other.SSN)
                {
                    return 1;
                }
                else if (this.SSN > other.SSN)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
