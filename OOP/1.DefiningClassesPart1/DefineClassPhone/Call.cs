using System;

namespace DefineClassPhone
{
    // Task 8
    // Create a class Call to hold a call performed through a GSM.
    // It should contain date, time, dialed phone number and duration (in seconds).

    class Call
    {
        // Filds
        private DateTime dateAndTime;
        private string dialedNumber;
        private int duration;

        // Properties
        public DateTime DateAndTime
        {
            get { return dateAndTime; }
            set { dateAndTime = value; }
        }

        public string DialedNumber
        {
            get { return dialedNumber; }
            set { dialedNumber = value; }
        }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value >= 0)
                {
                    this.duration = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        // Constructors
        public Call()            
        {
        }

        public Call(DateTime dateAndTime)
            : this(dateAndTime, null, 0)
        {
        }

        public Call(DateTime dateAndTime, string dialedNumber)
            : this(dateAndTime, dialedNumber, 0)
        {
        }

        public Call(DateTime dateAndTime, string dialedNumber, int duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }    
    }
}
