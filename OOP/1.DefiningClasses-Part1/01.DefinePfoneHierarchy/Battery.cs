using System;
using System.Text;

namespace DefinePfoneHierarchy
{
    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Enter a model of the battery!");
                }
                model = value;
            }
        }

        public int HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("The hoursIdle can not be less than zero!");
                }
                hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get { return hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("The hoursTalk can not be less than zero!");
                }
                hoursTalk = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("Battery: ");
            result.AppendFormat("{0}, {1}, {2}", this.Model, this.HoursIdle, this.HoursTalk);

            return result.ToString();
        }
    }
}
