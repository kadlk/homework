using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hm_13.Extensions;

namespace hm_13
{
    class Program
    {
        static void Main(string[] args)
        {
            StackT<int> stackT = new StackT<int>();
            int number = 3;
            stackT.Push(number);
            stackT.Push(number);
            int numberTemp = stackT.Pop();

            Stack stackStr = new Stack();
            string name = "string Vadim";
            stackStr.Push(name);
            stackStr.Push(name);
            stackStr.Push(name);

            stackStr.FreeElementsLeft();
            stackT.FreeElementsLeft();
            Console.Read();
        }
    }
}
