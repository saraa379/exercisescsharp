using System;

namespace Ex160
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex1 - Write an expression that checks whether an integer is odd or even.*/
            int number = 10;

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            } else {
                Console.WriteLine("The number is odd");
            }


            /*Ex2 - Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.*/
            int number2 = 10;
            //divisible by 5
            if (number2 % 5 == 0)
            {
                Console.WriteLine("The number is divisible by 5");
            }
            else
            {
                Console.WriteLine("The number is not divisble by 5");
            }

            //divisible by 7
            if (number2 % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else
            {
                Console.WriteLine("The number is not divisble by 7");
            }

            /*Write an expression that looks for a given integer if its third digit (right to left) is 7.*/
            int number3 = 12789;
            string str = number3.ToString();
            Console.WriteLine("Third digit is: " + str.Substring(2, 1));


            /*Write an expression that checks whether the third bit in a given integer is 1 or 0.*/

            int number4 = 12034;
            string strNr = number4.ToString();

            int thirdDigit = Int32.Parse(strNr.Substring(2, 1));
            
            if (thirdDigit == 0 || thirdDigit == 1)
            {
                Console.WriteLine("Third digit in int is 0 or 1");
            } else
            {
                Console.WriteLine("Third digit in int is not 0 or 1");
            }
        }
    }
}
