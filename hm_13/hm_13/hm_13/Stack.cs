using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_13
{
    public class Stack<T>
    {
        private T[] _items;
        private int _count;

        public Stack()
        {
            _items = new T[10];
        }

        public void Push(T item)
        {
            if (_count == 10)
                throw new StackMessageException("Stack has no free space");
            _items[_count++] = item;
        }
        public T Pop()
        {
            if (_count == 0)
                throw new StackMessageException("Stack is empty");
            T item = _items[--_count];
            return item;
        }

        public T Peek()
        {
            return _items[_count - 1];
        }
    }
}
