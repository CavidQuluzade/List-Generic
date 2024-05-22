using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskGenericMetod
{
    internal class GenericList<T>
    {
        public T[] Items { get { return items; } }
        private T[] items;
        public GenericList()
        {
            items = new T[0];
        }
        public void Swap(T item1, T item2)
        {
            T itemtemp;
            itemtemp = item1;
            item1 = item2;
            item2 = itemtemp;
            Console.WriteLine("First: " + item1 + "Second: " + item2);
        }
    }
}
