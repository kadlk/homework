using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_08
{
    class Program
    {

        static void Main(string[] args)
        {

            Luggage luggage = Luggage.CreateLuggage();

            CheckIn checkIn = new CheckIn();
            Console.WriteLine(checkIn.name);
            checkIn.AskOnlineReg();

            if (checkIn.isOnlineReg)
            {
                checkIn.OnlineRegistration();
            }
            else
            {
                checkIn.ReseptionRegistration(luggage);
            }
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nNow you are on security stand. We will check your luggage");
            Console.BackgroundColor = ConsoleColor.Black;

            bool isDrugControlPassed = false;
            bool isLuckyBoy = false;
            if (luggage.haveLuggage == false)
            {
                Console.WriteLine("\nOh, lucky. You have no luggage with you. Lets make a fast inspection of you. \nIts Okay. Go next. ");
                isDrugControlPassed = true;
            }
            else
            {
                Security security = new Security();
                security.DrugCheck(luggage);

                if (security.IsDrugCheckPassed)
                {
                    security.FluidCheck(luggage);
                    security.MoneyCheck(luggage);
                    isDrugControlPassed = true;

                    if (security.LuckyBoy)
                    {
                        isLuckyBoy = true;
                    }
                }
            }

            

            PassportControl passportControl = new PassportControl();
            if (isDrugControlPassed)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nNow you are on passport check stand.");
                Console.BackgroundColor = ConsoleColor.Black;

                passportControl.CheckName(checkIn);
                if (passportControl.IsCorrectName)
                {
                    passportControl.CheckVisa();
                }
            }
            
            Console.WriteLine("\nLets make a little summary:");
            Console.WriteLine($"Our airpot is {CheckIn.airportName} in {CheckIn.city}.  \nYour name: {checkIn.name}");
            Console.WriteLine($"Online registration: {checkIn.isOnlineReg}");
            Console.WriteLine($"Seat number: {checkIn.seatNumber}");
            if (checkIn.isOnlineReg)
            {
                Console.WriteLine($"Ticket number: {checkIn.ticketNumber}");
                Console.WriteLine($"Your chose {checkIn.boardingPassSendingMethod} delivery method of eTicket.");

            }
            Console.WriteLine();
            if (luggage.haveLuggage)
            {
                Console.WriteLine($"You had luggage. It weights {luggage.weight} killos.");
                if (luggage.moneyAmount > 10000)
                {
                    Console.WriteLine($"You had extra money: {luggage.moneyAmount - 10000} USD");
                }
                else
                {
                    Console.WriteLine("You had permited amount of money.");
                }

                if (luggage.fluidAmount > 5)
                {
                    Console.WriteLine($"You had extra fluid: {luggage.fluidAmount - 5} liters");
                }
                else
                {
                    Console.WriteLine("You had permited amount of fluid.");

                }

                if (luggage.haveDrugs)
                {
                    Console.WriteLine("You had drugs.");
                }
                else
                {
                    Console.WriteLine("No drugs with you");
                }
            }
            else
            {
                Console.WriteLine("You have no luggage.");
            }

            if (passportControl.HaveVisa)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Congrats! You passed this quest.");

                if (isLuckyBoy)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("And you passed this quest with DRUGS!!!!!");
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("You failed. Lets try one more time.");
            }
            Console.ReadKey();
        }
    }







}
