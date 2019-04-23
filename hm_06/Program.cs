using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a poem divided by semicolon in English");
            string[] splittedPoem = (Console.ReadLine()).Split(';');
            Console.WriteLine();

            for (int i = 0; i < splittedPoem.Length; i++)
            {
                splittedPoem[i] = splittedPoem[i].Replace('O', 'A');
            }

            foreach (var item in splittedPoem)
            {
                Console.WriteLine(item.Trim());
            }

            Console.Read();
        }
    }
}
