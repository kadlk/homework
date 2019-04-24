using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_13.Extensions
{
    static class StackExtensions
    {
        public static void FreeElementsLeft(this Stack stack)
        {
            int freeEl = 10 - stack.count;
            Console.WriteLine($"There is {freeEl} free space left");
        }

        public static void FreeElementsLeft<T>(this StackT<T> stack)
        {

            int freeEl = 10 - stack.count;
            Console.WriteLine($"There is {freeEl} free space left");
        }
    }
}
