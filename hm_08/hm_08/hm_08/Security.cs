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
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The game is over. Customers found all your drugs.\nGo to the prison");
                Console.BackgroundColor = ConsoleColor.Black;

                IsDrugCheckPassed = false;
            }
            else
            {
                Console.WriteLine("Its OK");
                IsDrugCheckPassed = true;
            }
        }
        public void MoneyCheck(Luggage luggage)
        {
            Console.WriteLine("Lets check your luggage on extra money. More than 10.000 USD");
            if (luggage.moneyAmount > 10000)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You will need to declare if money amount are greater than 10.000 USD.");
                Console.WriteLine($"Please declare your extra {luggage.moneyAmount - 10000} USD");
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
            Console.WriteLine("Lets check your luggage on extra fluid. More than 5 litres.");
            if (luggage.fluidAmount > 5)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"You will can not pass with more than 5 liters. Drop out your {luggage.fluidAmount - 5} liters. Thanks");
                Console.BackgroundColor = ConsoleColor.Black;
                isFluidCheckPassed = false;
            }
            else
            {
                Console.WriteLine("Its OK");
                isFluidCheckPassed = true;
            }
        }

    }
}
