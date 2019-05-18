using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_13
{
    public class Stack
    {
        private string[] _items;
        public int count;

        public Stack()
        {
            _items = new string[10];
        }

        public void Push(string item)
        {
            if (count == 10)
                throw new StackMessageException("Stack has no free space");
            _items[count++] = item;
        }
        public string Pop()
        {
            if (count == 0)
                throw new StackMessageException("Stack is empty");
            string item = _items[--count];
            return item;
        }

        public string Peek()
        {
            return _items[count - 1];
        }
    }
}

