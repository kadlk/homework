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
            Stack<string> stack = new Stack<string>();
            string name = "Vadim";
            stack.Push(name);
            string myName = stack.Pop();
            Console.WriteLine(myName);
        }
    }
}
