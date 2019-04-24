using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_13
{
    class Program
    {
        static void Main(string[] args)
        {
            StackT<int> stack = new StackT<int>();
            int number = 3;
            stack.Push(number);
            int numberTemp = stack.Pop();
            Console.WriteLine(numberTemp);

            Stack stackStr = new Stack();
            string name = "string Vadim";
            stackStr.Push(name);
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
