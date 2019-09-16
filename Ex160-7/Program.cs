using System;

namespace Ex160_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex7 - The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that 
              calculates the weight of a man on the moon by a given weight on the Earth.*/
            int weight = 70;
            double weightOnMoon = (weight * 17) / 100;
            Console.WriteLine("Weight on the moon is: " + weightOnMoon);

            /*Ex8 - Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5). 
              Explanation: the point {0, 0} is the center of the circle and 5 is the radius.*/
            int x = 3;
            int y = 2;
            int r = 5;

            double distance = (double)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine("The distance is: " + distance);

            if (distance < r)
            {
                Console.WriteLine("The point is inside a circle");
            } else
            {
                Console.WriteLine("The point is not inside a circle");
            }


            /*Ex9 - Write an expression that checks for given point {x, y} if it is within the circle K({0, 0}, R=5) 
             and out of the rectangle [{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.*/

        }
    }
}
