using System;

namespace Ex160_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex 10 - Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
                - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
                - Prints on the console the number in reversed order: dcba (in our example 1102).
                - Puts the last digit in the first position: dabc (in our example 1201).
                - Exchanges the second and the third digits: acbd (in our example 2101).*/


            Console.Write("Enter a 4 digit: ");
            int inputNr = Int32.Parse(Console.ReadLine());
            //Getting individual digits
            int a = inputNr % 10;
            int b = (inputNr / 10) % 10;
            int c = (inputNr / 100) % 10;
            int d = (inputNr / 1000) % 10;
            Console.WriteLine("a is: " + a);
            Console.WriteLine("b is: " + b);
            Console.WriteLine("c is: " + c);
            Console.WriteLine("d is: " + d);

            //sum of the digits
            int sum = a + b + c + d;
            Console.WriteLine("the sum of digits is: " + sum);

            //number in reversed order
            Console.WriteLine("reversed order: " + a + b + c + d);

            //last digit in the first position
            Console.WriteLine("last digit in the first position: " + a + d + c + b);

            //Exchanges the second and the third digits
            Console.WriteLine("last digit in the first position: " + d + b + c + a);
        }
    }
}
