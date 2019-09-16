using System;

namespace Ex160_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*We are given a number n and a position p. Write a sequence of operations that prints the value of the bit 
             on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.*/

            int n = 35; // 00100011 
            int p = 6;
            int i = 1; // 00000001 
            int mask = i << p; // Move the 1-st bit left by p positions 
            // If i & mask are positive then the p-th bit of n is 1 
            Console.WriteLine((n & mask) != 0 ? 1 : 0);


            /*Ex11 - Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. 
             Example v=5, p=1 -> false.*/

            int v = 5;
            int p2 = 1;
            int mask2 = i << p2; // Move the 1-st bit left by p positions 
            // If i & mask are positive then the p-th bit of n is 1
            Console.WriteLine((n & mask) != 0 ? true : false);


            /*We are given the number n, the value v (v = 0 or 1) and the position p. write a sequence of operations that changes 
             the value of n, so the bit on the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. 
             Another example: n=35, p=2, v=1 -> n=39.*/
        }
    }
}
