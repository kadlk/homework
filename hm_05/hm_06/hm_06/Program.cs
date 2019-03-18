using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the length of array");
            int arrLength = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[arrLength];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine("Input " + i + " value");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Postition");
            int inputtedPos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value");
            int inputtedValue = Convert.ToInt32(Console.ReadLine());

            for (int i = arr.Length - 1; i > inputtedPos; i--)
                arr[i] = arr[i - 1];

            arr[inputtedPos] = inputtedValue;

            foreach (var item in arr)
                Console.WriteLine(item);

            Console.Read();
        }
    }
}
