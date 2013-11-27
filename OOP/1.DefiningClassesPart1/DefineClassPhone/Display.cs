using System;

namespace DefineClassPhone
{
    public class Display
    {
        // Filds
        private int size;
        private int numberOfCollors;

        // Properties
        public int Size
        {
            get { return size; }
            set
            {
                if (value >= 0)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int NumberOfCollors
        {
            get { return numberOfCollors; }
            set
            {
                if (value >= 0)
                {
                    this.numberOfCollors = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        
        //Constructors
        public Display()
        {
        }

        public Display(int size) 
            : this(size, 0)
        {
        }

        public Display(int size, int numberOfCollors)
        {
            this.Size = size;
            this.NumberOfCollors = numberOfCollors;
        }        
    }
}
