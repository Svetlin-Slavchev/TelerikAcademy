using System;

namespace DefineClassPhone
{
    // Enumerations - task 3
    // Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    public class Battery
    {
        // Filds
        private BatteryType model;
        private int hoursIdle;
        private int hoursTalk;

        // Properties
        public BatteryType Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int HoursIdle
        {
            get { return hoursIdle; }
            set 
            {
                if (value >= 0)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value >= 0)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        // Constructors
        public Battery()
        {
        }

        public Battery(BatteryType model) 
            : this(model, 0, 0)
        {
        }

        public Battery(BatteryType model, int hoursIdle) 
            : this(model, hoursIdle, 0)
        {
        }

        public Battery(BatteryType model, int hoursIdle, int hoursTalk)          
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }      
    }
}
