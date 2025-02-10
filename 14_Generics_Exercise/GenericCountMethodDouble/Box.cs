using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodDouble
{
    public class Box<T> where T : IComparable<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }
        public int CountLarger(List<T> list)
        {
            int count = 0;
            foreach (T item in list)
            {
                if (item.CompareTo(value) > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public override string ToString()
        {
            return $"{typeof(T).FullName}: {value}";
        }
    }
}
