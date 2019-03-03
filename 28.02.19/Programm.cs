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
           
            // unboxing
            i = (int)o;


            
            sbyte vSbyte = 1;
            System.SByte vSbyte2 = vSbyte;
            Console.WriteLine("sbyte");
            Console.WriteLine(vSbyte.GetType());
            Console.WriteLine(vSbyte2.GetType());
            Console.WriteLine();

            short vShort = 1;
            System.Int16 vShort2 = vShort;
            Console.WriteLine("short");
            Console.WriteLine(vShort.GetType());
            Console.WriteLine(vShort2.GetType());
            Console.WriteLine();


            int vInt = 1;
            System.Int32 vInt2 = vInt;
            Console.WriteLine("int");
            Console.WriteLine(vInt.GetType());
            Console.WriteLine(vInt2.GetType());
            Console.WriteLine();

            long vLong = 1;
            System.Int64 vLong2 = vLong;
            Console.WriteLine("long");
            Console.WriteLine(vLong.GetType());
            Console.WriteLine(vLong2.GetType());
            Console.WriteLine();

            byte vByte = 1;
            System.Byte vByte2 = vByte;
            Console.WriteLine("byte");
            Console.WriteLine(vByte.GetType());
            Console.WriteLine(vByte2.GetType());
            Console.WriteLine();

            ushort vUshort = 1;
            System.UInt16 vUshort2 = vUshort;
            Console.WriteLine("ushort");
            Console.WriteLine(vUshort.GetType());
            Console.WriteLine(vUshort2.GetType());
            Console.WriteLine();

            char vChar = '\x5A';
            System.Char vChar2 = vChar;
            Console.WriteLine("char");
            Console.WriteLine(vChar.GetType());
            Console.WriteLine(vChar2.GetType());
            Console.WriteLine();

            uint vUint = 1;
            System.UInt32 vUint2 = vUint;
            Console.WriteLine("uint");
            Console.WriteLine(vUint.GetType());
            Console.WriteLine(vUint2.GetType());
            Console.WriteLine();

            ulong vUlong = 1;
            System.UInt64 vUlong2 = vUlong;
            Console.WriteLine("ulong");
            Console.WriteLine(vUlong.GetType());
            Console.WriteLine(vUlong2.GetType());
            Console.WriteLine();

            float vFloat = 1.1f;
            System.Single vFloat2 = vFloat;
            Console.WriteLine("float");
            Console.WriteLine(vFloat.GetType());
            Console.WriteLine(vFloat2.GetType());
            Console.WriteLine();

            double vDouble = 1.1f;
            System.Double vDouble2 = vDouble;
            Console.WriteLine("double");
            Console.WriteLine(vDouble.GetType());
            Console.WriteLine(vDouble2.GetType());
            Console.WriteLine();

            decimal vDecimal = 1.1m;
            System.Decimal vDecimal2 = vDecimal;
            Console.WriteLine("decimal");
            Console.WriteLine(vDecimal.GetType());
            Console.WriteLine(vDecimal2.GetType());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
