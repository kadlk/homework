using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine()).ToUpper();

            switch (input)
            {
                case "W":
                    {
                        Console.WriteLine("Up");
                        break;
                    }
                case "A":
                    {
                        Console.WriteLine("Left");
                        break;
                    }
                case "S":
                    {
                        Console.WriteLine("Down");
                        break;
                    }
                case "D":
                    {
                        Console.WriteLine("Right");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("No need to move"); 
                    }
                    break;
            }

            Console.ReadLine(); 
        }
    }
}
