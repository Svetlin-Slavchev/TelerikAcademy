using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_DefineClasses_HumanStudentWorker
{
    public class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;

        // Properties
        public double WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }
       
        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        public double MoneyPerHour(double weekSalary, int workHoursPerDay)
        {
            return weekSalary / workHoursPerDay;
        }

        // Constructors
        public Worker()
        {
        }

        public Worker(string firstName, string lastName)
           : base (firstName, lastName)
        {
        }

        public Worker(string firstName, string lastName, double weekSalary)
            : this(firstName, lastName, weekSalary, 0)
        {
        }

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
    }
}
