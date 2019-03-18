using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] arrRandom = new int[5];
            int[] arrInput = new int[5];
            int[] arrSum = new int[5];

            for (int i = 0; i < arrRandom.Length; i++)
            {
                int rndNumber = rnd.Next(0, 100);
                arrRandom[i] = rndNumber;
            }

            Console.WriteLine("Input 5 numeric value");
            for (int i = 0; i < arrInput.Length; i++)
                arrInput[i] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arrSum.Length; i++)
                arrSum[i] = arrRandom[i] + arrInput[i];

            Console.WriteLine("Random numbers");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arrRandom[i]);

            Console.WriteLine("Inputed numbers");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arrInput[i]);

            Console.WriteLine("Summed numbers");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arrSum[i]);

            Console.Read();
        }
    }
}
