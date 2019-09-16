/*Which of the following values can be assigned to variables of type float, double and decimal: 
  5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?*/

using System;

namespace Ex135_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float floatNr = 5.0f;
            Console.WriteLine("Float number: " + floatNr);

            float floatNr2 = -5.01f;
            Console.WriteLine("Float number2: " + floatNr2);

            double doubleNr = 34.567839023;
            Console.WriteLine("Double number: " + doubleNr);

            float floatNr3 = 12.345f;
            Console.WriteLine("Float number 3: " + floatNr3);

            double doubleNr2 = 8923.1234857;
            Console.WriteLine("Double number 2: " + doubleNr2);

            decimal decimalNr = 3456.091124875956542151256683467m;
            Console.WriteLine("Decimal number: " + decimalNr);
        }
    }
}
