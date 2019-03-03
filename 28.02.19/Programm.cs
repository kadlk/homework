using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Kontush_2_lesson
{
    class Programm
    {
        static void Main(string[] args)
        {
            // implicit conversion
            sbyte valueSbyte = 1;
            short valueShort = valueSbyte;

            ulong valueUlong = 10;
            decimal valueDecimal = valueUlong;

            char valueChar = '\x5A';
            float valueFloat = valueChar;


            // explicit conversion
            int valueInt = 123;
            byte valueByte = (byte)valueInt;

            short valueShort2 = 123;
            sbyte valueSByte = Convert.ToSByte(valueShort2);

            string letters = "125";
            int convertedLetters = Convert.ToInt32(letters);


            // boxing example
            int i = 123;
            object o = i;
            i = 222;
            Console.WriteLine(o);
            Console.WriteLine(i);
           
            
            // unboxing
            i = (int)o;
            Console.WriteLine(i);
        }
    }
}
