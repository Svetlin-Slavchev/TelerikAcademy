using System;

namespace Task1_DefineClasses
{
    public class SchoolClass : School
    {
        private string textIdentifier;

        public string TextIdentifier
        {
            get { return textIdentifier; }
            set { textIdentifier = value; }
        }

        // Constructors
        public SchoolClass()
        {
        }

        public SchoolClass(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
        }
    }
}
