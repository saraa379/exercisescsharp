using System;

namespace Ex160_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write an expression that calculates the area of a trapezoid by given sides a, b and height h*/
            int a = 13;
            int b = 8;
            int height = 7;

            int sumOfSides = a + b;
            double area = (double)(sumOfSides * height) / 2;
            Console.WriteLine("Area of the trapezoi is: " + area);


            /*Write a program that prints on the console the perimeter and the area of a rectangle by given side 
              and height entered by the user*/

            Console.WriteLine("Enter the rectangle side: ");
            int side = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The side value entered is: " + side);

            Console.WriteLine("Enter the height: ");
            int recHeight = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The height value entered is: " + recHeight);

            int perimeter = 2 * (side + recHeight);

            Console.WriteLine("The perimeter of rectangle is: " + perimeter);
        }
    }
}
