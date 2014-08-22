using System;
using System.Text;

namespace DefinePfoneHierarchy
{
    public class Display
    {
        private int size;
        private int numberOfCollors;

        public Display(int size, int numberOfCollors)
        {
            this.Size = size;
            this.NumberOfCollors = numberOfCollors;
        }

        public int Size
        {
            get { return size; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("The size can not be less than zero!");
                }
                size = value;
            }
        }

        public int NumberOfCollors
        {
            get { return numberOfCollors; }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("The numberOfCollors can not be less than zero!");
                }
                numberOfCollors = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append("Display: ");
            result.AppendFormat("{0}, {1}", this.Size, this.NumberOfCollors);

            return result.ToString();
        }
    }
}
