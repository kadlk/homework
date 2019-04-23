using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_08
{
    class Luggage
    {
        public bool haveLuggage;
        public int weight;
        public int moneyAmount;
        public int fluidAmount;
        public bool haveDrugs;

        public Luggage(bool haveLuggage)
        {
            this.haveLuggage = haveLuggage;
        }
        public Luggage(int weight, int moneyAmount, int fluidAmount, bool haveDrugs)
        {
            haveLuggage = true;
            this.weight = weight;
            this.moneyAmount = moneyAmount;
            this.fluidAmount = fluidAmount;
            this.haveDrugs = haveDrugs;
        }

        public static Luggage CreateLuggage()
        {
            bool haveLuggage = false;

            string input;
            do
            {
                Console.WriteLine("You recived a link before your trip. Lets open it.");
                Console.WriteLine("\nHello, do you have any luggage? You can register it online. \nType: YES or NO.");
                input = Console.ReadLine();

                if (input.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    haveLuggage = true;
                }

                else if (input.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Oh, such a great news!");
                    haveLuggage = false;
                }

                else
                {
                    Console.WriteLine("Wrong answer.");
                }

            } while (!input.Equals("yes", StringComparison.InvariantCultureIgnoreCase) && !input.Equals("no", StringComparison.InvariantCultureIgnoreCase));

            if (!haveLuggage)
            {
                return new Luggage(false);
            }

            else
            {
                Console.WriteLine("Lets register it.");
                Console.WriteLine("\nEnter weight in kg");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter money amount");
                int moneyAmount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nEnter fluid amount in litres");
                int fluidAmount = Convert.ToInt32(Console.ReadLine());
                bool haveDrugs = false;

                //Console.WriteLine("Do you have any drugs ? Type : YES or NO");
                //input = Console.ReadLine();
                do
                {
                    Console.WriteLine("\nDo you have any drugs? Type: YES or NO");
                    input = Console.ReadLine();

                    if (input.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                    {
                        haveDrugs = true;
                        Console.WriteLine("Dummy, dummy... \nYou should be very lucky to go abroad with drugs.");
                    }

                    else if (input.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                    {
                        haveDrugs = false;
                    }

                    else
                    {
                        Console.WriteLine("\nWrong answer.");
                    }

                } while (!input.Equals("yes", StringComparison.InvariantCultureIgnoreCase) && !input.Equals("no", StringComparison.InvariantCultureIgnoreCase));

                return new Luggage(weight, moneyAmount, fluidAmount, haveDrugs);
            }
        }
    }
}
