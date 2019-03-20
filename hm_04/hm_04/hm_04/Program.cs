using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 90; i >= 65; i--)
            {
                char letter = (char)i;
                Console.WriteLine(letter);
            }
            
            Console.Read();
        }
    }
}
