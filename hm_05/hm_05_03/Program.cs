using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            foreach (var item in arr)
                Console.WriteLine(item);

            Console.Read();
        }
    }
}
