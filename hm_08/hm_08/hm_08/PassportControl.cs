using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_08
{
    class PassportControl
    {
        public bool IsCorrectName { get; set; } = false;
        public bool HaveVisa { get; set; } = false;
        public void CheckName(CheckIn checkIn)
        {
            Console.WriteLine("Give me your passport. Lets Check your name.\nSay please your REAL name.");
            string input = Console.ReadLine();

            if (input.Equals(checkIn.name, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("God damn right. Its you.");
                IsCorrectName = true;
            }
            else
            {
                Console.WriteLine("You failed. Its not you - go home");
                IsCorrectName = false;
            }

        }

        public void CheckVisa()
        {
            string input;
            do
            {
                Console.WriteLine("\nLets check your visa. Do you have visa? \nType: YES or NO");
                input = Console.ReadLine();

                if (input.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("\nWell, well. Your visa is OK.");
                    HaveVisa = true;
                }

                else if (input.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("\nYou have no visa - go home!");
                    HaveVisa = false;
                }

                else
                {
                    Console.WriteLine("\nWrong answer.");

                }

            } while (!input.Equals("yes", StringComparison.InvariantCultureIgnoreCase) && !input.Equals("no", StringComparison.InvariantCultureIgnoreCase));

        }



    }
}
