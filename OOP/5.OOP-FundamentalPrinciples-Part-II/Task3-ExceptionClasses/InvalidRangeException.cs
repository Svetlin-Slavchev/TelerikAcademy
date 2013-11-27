using System;

namespace Task3_ExceptionClasses
{
    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable<T>
    {
        public InvalidRangeException(string msg)
            : base(msg)
        {
        }
    }
}
