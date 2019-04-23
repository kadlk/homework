using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_try
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int index = 0;
            int index1 = index;
            int index2 = index1 + arr.Length - 1;

            for (; index1 < index2; index2--)
            {
                int tempIndex = arr[index1];
                arr[index1] = arr[index2];
                arr[index2] = tempIndex;
                index1++;
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
