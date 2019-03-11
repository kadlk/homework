using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_03_Kontush
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstHM();
            //SecondHM();
            //ThirdHM();
            FourthHM();
           
            Console.ReadKey();
        }

        public static int Input()
        {
            Console.WriteLine("Input number");
            bool resultA = int.TryParse(Console.ReadLine(), out int a);
            while (resultA == false)
            {
                Console.WriteLine();
                Console.WriteLine("It is not a numeric value. Try one more time");
                Console.WriteLine("Input number");
                resultA = int.TryParse(Console.ReadLine(), out a);
            }
            return a;
        }
        public static int Add2Numbers(int number1, int number2)
        {
            return number1 + number2;
        }
        public static int Sub2Numbers(int number1, int number2)
        {
            return number1 - number2;
        }
        public static string WhatsOperator()
        {
            Console.WriteLine("Input operator + or -");
            string plusOrMinus = Console.ReadLine();
            while (plusOrMinus != "+" && plusOrMinus != "-")
            {
                Console.WriteLine("Wrong. Try one more time");
                plusOrMinus = Console.ReadLine();
            }
            return plusOrMinus; 
        }


        public static void FirstHM()
        {
            int first = Input();
            int second = Input();
            int result = Add2Numbers(first, second);
            Console.WriteLine("The sum is " + result);
        }
        public static void SecondHM()
        {
            int first = Input();
            int second = Input();
            int result = Add2Numbers(first, second);
            Console.WriteLine("Input your answer");
            int answer = Input();
            if (answer == result)
            {
                Console.WriteLine("You are right");
            }
            else
            {
                Console.WriteLine("Wrong answer");
            }
        }
        public static void ThirdHM()
        {
            int first = Input();
            int second = Input();
            int result = Add2Numbers(first, second);
            Console.WriteLine("Input your answer");
            int answer = Input();
            if (answer == result)
            {
                Console.WriteLine("You are right");
            }
            else
            {
                if (answer > result)
                {
                    Console.WriteLine("Wrong answer");
                    Console.WriteLine("Right answer is smaller");
                }

                if (answer < result)
                {
                    Console.WriteLine("Wrong answer");
                    Console.WriteLine("Right answer is bigger");
                }
            }
        }
        public static void FourthHM()
        {
            int first = Input();
            int second = Input();
            string plusMinus = WhatsOperator();
            int result;

            if (plusMinus == "+")
            {
                result = Add2Numbers(first, second);
            }
            else
            {
                result = Sub2Numbers(first, second);
            }
            
            Console.WriteLine("Input your answer");
            int answer = Input();
            if (answer == result)
            {
                Console.WriteLine("You are right");
            }
            else
            {
                if (answer > result)
                {
                    Console.WriteLine("Wrong answer");
                    Console.WriteLine("Right answer is smaller");
                }

                if (answer < result)
                {
                    Console.WriteLine("Wrong answer");
                    Console.WriteLine("Right answer is bigger");
                }
            }
        }
    }
}
