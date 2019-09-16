using System;

namespace Ex135
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Exercise 1 - Declare several variables by selecting for each one of them the most appropriate of the types sbyte, 
            byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 
            97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789.*/

            float floatNr = 52.130f;
            Console.WriteLine("Float number: " + floatNr);

            sbyte sbyteNr = -115;
            Console.WriteLine("Sbyte number: " + sbyteNr);

            int intNr = 4825932;
            Console.WriteLine("Int number: " + intNr);

            sbyte sbyteNr2 = 97;
            Console.WriteLine("Sbyte number 2: " + sbyteNr2);

            short shortNr = -10000;
            Console.WriteLine("Short number: " + shortNr);

            short shortNr2 = 20000;
            Console.WriteLine("Short number 2: " + shortNr2);

            byte byteNr = 224;
            Console.WriteLine("Byte number: " + byteNr);

            int intNr2 = 970700000;
            Console.WriteLine("Int number 2: " + intNr2);

            sbyte sbyteNr3 = 112;
            Console.WriteLine("Sbyte number 3: " + sbyteNr3);

            sbyte sbyteNr4 = -44;
            Console.WriteLine("Sbyte number 4: " + sbyteNr4);

            int intNr3 = -1000000;
            Console.WriteLine("Int number 3: " + intNr3);

            short shortNr3 = 1990;
            Console.WriteLine("Short number 3: " + shortNr3);

            long longNr = 123456789123456789L;
            Console.WriteLine("Long number: " + longNr);
        }
    }
}
