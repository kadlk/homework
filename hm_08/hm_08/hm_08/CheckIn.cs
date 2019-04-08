using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_08
{
    class CheckIn
    {
        //Using CONST
        public const string city = "Minsk";
        public const string airportName = "Minsk - 2";

        public string name;
        public bool isOnlineReg;
        public string ticketNumber;
        public string seatNumber;
        public bool isOverWeight;
        public string boardingPassSendingMethod;

        public void AskOnlineReg()
        {
            Console.WriteLine("\nDo you want to register online? (You will have no need to checkIn in airport. \nType: YES or NO");
            string input = Console.ReadLine();

            if (input.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
            {
                isOnlineReg = true;
            }

            else if (input.Equals("no", StringComparison.InvariantCultureIgnoreCase))
            {
                isOnlineReg = false;
            }

            else
            {
                Console.WriteLine("Wrong answer");
                AskOnlineReg();
            }
        }
        public void OnlineRegistration()
        {
            Console.WriteLine("\nRedirecting to Belavia.by ... \nEnter your ticket number:");
            ticketNumber = Console.ReadLine();

            Console.WriteLine("\nEnter your name:");
            name = Console.ReadLine();

            Console.WriteLine("\nEnter your seat number:");
            seatNumber = Console.ReadLine();

            string input;
            do
            {
                Console.WriteLine("\nDo you need to register overweight luggage? (Over 20kg) \nType: YES or NO");
                input = Console.ReadLine();

                if (input.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    isOverWeight = true;
                }

                else if (input.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                {
                    isOverWeight = false;
                }

                else
                {
                    Console.WriteLine("\nWrong answer.");

                }

            } while (!input.Equals("yes", StringComparison.InvariantCultureIgnoreCase) && !input.Equals("no", StringComparison.InvariantCultureIgnoreCase));

            do
            {
                Console.WriteLine("What boarding pass delivering way do you prefer? Type: Email or SMS?");
                boardingPassSendingMethod = Console.ReadLine();
                if (boardingPassSendingMethod.Equals("Email", StringComparison.InvariantCultureIgnoreCase))
                {
                    boardingPassSendingMethod = "Email";
                    Console.WriteLine("Dont forget to print your email.");
                }

                else if (boardingPassSendingMethod.Equals("SMS", StringComparison.InvariantCultureIgnoreCase))
                {
                    boardingPassSendingMethod = "SMS";
                    Console.WriteLine("Dont forget. You will be need Internet connection.");
                }

                else
                {
                    Console.WriteLine("Wrong answer");
                }

            } while (!boardingPassSendingMethod.Equals("Email", StringComparison.InvariantCultureIgnoreCase) && !boardingPassSendingMethod.Equals("SMS", StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine("\nHave a nice trip.");
        }

        // Перегрузка метода
        public void ReseptionRegistration(Luggage luggage, bool hrenaggage)
        {

        }
        public void ReseptionRegistration(Luggage luggage)
        {
            string time = DateTime.Now.ToString("HH:mm");

            Console.WriteLine("\nYou are on the reseption stand.");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine($"\nHello {name}, it is {time} o`clock. \nWe are glad to see you at our airport. \nGive me your passport.");
            Console.WriteLine("...");
            Console.WriteLine("\nThanks, its all OK.");

            if (luggage.haveLuggage)
            {
                if (luggage.weight > 20)
                {
                    int over = luggage.weight - 20;
                    Console.WriteLine($"\nYour luggage is overweighted by {over} kg. Please pay extra money 1kg - 10$. You need to pay {over * 10}$.");
                }
                else
                {
                    Console.WriteLine("\nLets weight your luggage.");

                    Random random = new Random();
                    if (random.Next(0, 21) < 10)
                    {
                        isOverWeight = false;
                        Console.WriteLine("\nIts ok.");
                    }
                    else
                    {
                        isOverWeight = true;
                        Console.WriteLine("\nAhahah. You`ll need to pay for overweight.");
                    }
                }
            }

            Random random1 = new Random();
            seatNumber = Convert.ToString(random1.Next(1, 120));
            Console.WriteLine($"\nHere is your boarding ticket. Your seat number is {seatNumber}");
        }
    }
}

