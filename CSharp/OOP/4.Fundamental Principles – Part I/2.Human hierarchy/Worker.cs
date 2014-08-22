using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Human_hierarchy
{
    public class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public double WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("The number must be positive!");
                }
                workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, week salary: {2}, work hours per day: {3}", this.FirstName, this.LastName,
                this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
