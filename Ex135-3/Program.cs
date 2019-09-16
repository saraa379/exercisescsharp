using System;

namespace Ex135_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex3 - Write a program, which compares correctly two real numbers with accuracy at least 0.000001.*/

            decimal a = 0.000001m;
            decimal b = 0.0000015m;

            if (a == b)
            {
                Console.WriteLine("a equals b");
            } else
            {
                Console.WriteLine("a and b are not same");
            }


            /*Ex4 - Initialize a variable of type int with a value of 256 in hexadecimal format (256 is 100 in a numeral system with base 16).*/

            int hexNr = 0x100;
            Console.WriteLine("Hex number is: " + hexNr);  //256


            /*Ex5 - Declare a variable of type char and assign it as a value the character, which has Unicode code, 
             72 (use the Windows calculator in order to find hexadecimal representation of 72).*/

            char charValue = '\u0048';
            Console.WriteLine("Char value is: " + charValue);  //H


            /*Ex6 - Declare a variable isMale of type bool and assign a value to it depending on your gender.*/

            bool isMale = false;
            Console.WriteLine("Am I male: " + isMale);


            /*Declare two variables of type string with values "Hello" and "World". Declare a variable of type object. 
             Assign the value obtained of concatenation of the two string variables (add space if necessary) to this variable. 
             Print the variable of type object.*/

            string hello = "Hello";
            string world = "World";
            object joined = hello + " " + world;
            Console.WriteLine(joined);


            /*Declare two variables of type string and give them values "Hello" and "World". Assign the value obtained by 
             the concatenation of the two variables of type string (do not miss the space in the middle) to a variable of 
             type object. Declare a third variable of type string and initialize it with the value of the variable of type object (you should use type casting).*/

            string strJoined = (string)joined;
            Console.WriteLine("String version of joined variable: " + strJoined);


            /*Declare two variables of type string and assign them a value “The "use" of quotations causes difficulties.” 
             (without the outer quotes). In one of the variables use quoted string and in the other do not use it.*/

            string withQuotes = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(withQuotes);

        }
    }
}
