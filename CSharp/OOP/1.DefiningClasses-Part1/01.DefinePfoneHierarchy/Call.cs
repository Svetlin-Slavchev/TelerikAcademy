using System;
using System.Collections.Generic;
using System.Text;

// task 8
// Create a class Call to hold a call performed through a GSM. It should contain date, time, 
// dialed phone number and duration (in seconds).

namespace DefinePfoneHierarchy
{
    public class Call
    {
        private DateTime date;
        private string number;
        private double duration;

        public Call(DateTime date, string number, double duration)
        {
            this.Date = date;
            this.Number = number;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public double Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("Calls: ");
            result.AppendFormat("{0}, {1}, {2}", this.Date, this.Number, this.Duration);

            return result.ToString();
        }
    }
}
