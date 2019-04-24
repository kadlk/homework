using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_13
{
    public class StackT<T>
    {
        private T[] _items;
        public int count;

        public StackT()
        {
            _items = new T[10];
        }

        public void Push(T item)
        {
            if (count == 10)
                throw new StackMessageException("Stack has no free space");
            _items[count++] = item;
        }
        public T Pop()
        {
            if (count == 0)
                throw new StackMessageException("Stack is empty");
            T item = _items[--count];
            return item;
        }

        public T Peek()
        {
            return _items[count - 1];
        }
    }
}
