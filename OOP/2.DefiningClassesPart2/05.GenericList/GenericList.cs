using System;
using System.Linq;
using System.Text;

namespace GenericList
{
    // Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
    // Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
    // Implement methods for adding element, accessing element by index, removing element by index,
    // inserting element at given position, clearing the list, finding element by its value and ToString().
    // Check all input parameters to avoid accessing elements at invalid positions.

    class GenericList<T> where T : IComparable<T>
    {
        // Filds
        private T[] elements;
        private int count;

        // Connstructor
        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        // Properties
        public int Count
        {
            get { return count; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
                T result = elements[index];
                return result;
            }
        }

        // Methods
        // Task 6:
        // Implement auto-grow functionality: when the internal array is full, create a new array of double size
        // and move all elements to it.

        public void AutoGrowCapacity()
        {
            T[] newElements = new T[elements.Length * 2];
            Array.Copy(this.elements, newElements, elements.Length);
            elements = newElements;
        }

        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                AutoGrowCapacity();
            }

            this.elements[count] = element;
            count++;
        }

        public T AccsesAt(int index)
        {
            if (index < 0 || index > elements.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            dynamic element = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (i != index)
                {
                    continue;
                }
                else if (i == index)
                {
                    element = elements[i];
                }
            }
            return element;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > elements.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            dynamic element = this.elements[index];
            for (int i = index; i < elements.Length - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            elements[count - 1] = default(T);  // defaut(T) means null or 0 in other types
            this.count--;             
        }

        public void Insert(int index, T value)
        {
            if (index < 0 || index > elements.Length)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }

            T[] newElements = new T[elements.Length + 1];
            Array.Copy(this.elements, newElements, elements.Length);
            elements = newElements;
            for (int i = elements.Length - 1; i > index; i--)
            {
                elements[i] = elements[i - 1];
            }
            elements[index] = value;
            this.count++;
        }

        public T FindByValue(T value)
        {   
            // Only for arrays. Don't use it whit lists.
            // Array.Sort(elements);
            // dynamic index = Array.BinarySearch(elements, value);
            // return index;
            dynamic result = "";
            for (int i = 0; i < elements.Length; i++)
            {
                if (Convert.ToString(elements[i]) == Convert.ToString(value))
                {
                    result = i;
                }
            }
            return result;
        }

        public void Clear()
        {
            Array.Clear(elements, 0, elements.Length);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < elements.Length; i++)
            {
                sb.Append(" " + elements[i]);
            }
            sb.Append("]");
            return sb.ToString();
        }

        // Task 7
        // Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>.
        // You may need to add a generic constraints for the type T.

        public T Min<T>()
           where T : IComparable<T>
        {
            dynamic minElement = int.MaxValue;
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i] < minElement)
                {
                    minElement = this.elements[i];
                }
            }
            return minElement;
        }

        public T Max<T>()
           where T : IComparable<T>
        {
            dynamic maxElement = int.MinValue;
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i] > maxElement)
                {
                    maxElement = this.elements[i];
                }
            }
            return maxElement;
        }
    }
}
