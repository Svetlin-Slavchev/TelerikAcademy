using System;
using System.Collections.Generic;

namespace Task5_ClassBitArray64
{
    public class BitArray64 : IEnumerable<ulong>
    {
        private ulong number;

        public ulong Number
        {
            get { return number; }
            set { number = value; }
        }

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        // overriding []
        public ulong this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range (0 - 63).");
                }

                return (ulong)((this.number >> index) & 1);
            }
        }

        public IEnumerator<ulong> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override bool Equals(Object obj)
        {
            BitArray64 num = obj as BitArray64;
            if (num == null)
            {
                return false;
            }
            else if (this.Number != num.Number)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(BitArray64 num, BitArray64 num2)
        {
            return BitArray64.Equals(num, num2);
        }

        public static bool operator !=(BitArray64 num, BitArray64 num2)
        {
            return !(BitArray64.Equals(num, num2));
        }
    }
}
