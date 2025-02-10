using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        public Stack<T> items =new Stack<T> ();
        public void Add(T item)
        {
            items.Push (item);
        }
        public T Remove()
        {
            return items.Pop ();
        }
        public int Count { get { return items.Count; } }
    }       
}
