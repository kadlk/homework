using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_08
{
    class Security
    {
        // Using fields and properties to train it
        public bool IsDrugCheckPassed { get; set; }
        public bool LuckyBoy { get; set; } = false;
        public bool isFluidCheckPassed;

        private bool isMoneyCheckPassed;
        public bool IsMoneyCheckPassed
        {
            get
            {
                return isMoneyCheckPassed;
            }
            set
            {
                isMoneyCheckPassed = value;
            }
        }


        public void DrugCheck(Luggage luggage)
        {
            Console.WriteLine("Lets check your luggage on DRUGS.");
            if (luggage.haveDrugs)
            {

                Console.WriteLine("You know that drugs are forbid to travel. But you are lucky boy, lets roll a dice.\nIf it will" +
                    "be 1 or 2 - you Win another way you will go in JAIL!");
                Random random = new Random();
                Console.WriteLine($"You throw a dice and you have {random.Next(1, 7)}");
                
                if (2 < random.Next(1, 7))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("The game is over. Customers found all your drugs.\nGo to the prison");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nYou are lucky today");
                    Console.BackgroundColor = ConsoleColor.Black;
                    LuckyBoy = true;
                    IsDrugCheckPassed = true;
                }
            }
            else
            {
                Console.WriteLine("Its OK");
                IsDrugCheckPassed = true;
            }
        }
        public void MoneyCheck(Luggage luggage)
        {
            Console.WriteLine("\nLets check your luggage on extra money. More than 10.000 USD");
            if (luggage.moneyAmount > 10000)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nYou will need to declare if money amount are greater than 10.000 USD.");
                Console.WriteLine($"\nPlease declare your extra {luggage.moneyAmount - 10000} USD");
                Console.BackgroundColor = ConsoleColor.Black;


                isMoneyCheckPassed = false;
            }
            else
            {
                Console.WriteLine("Its OK");
                isMoneyCheckPassed = true;
            }
        }

        public void FluidCheck(Luggage luggage)
        {
            Console.WriteLine("\nLets check your luggage on extra fluid. More than 5 litres.");
            if (luggage.fluidAmount > 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"\nYou will can not pass with more than 5 liters. Drop out your {luggage.fluidAmount - 5} liters. Thanks");
                Console.BackgroundColor = ConsoleColor.Black;
                isFluidCheckPassed = false;
            }
            else
            {
                Console.WriteLine("\nIts OK");
                isFluidCheckPassed = true;
            }
        }

    }
}
