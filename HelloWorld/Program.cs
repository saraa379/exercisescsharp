using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter a name.
            Console.WriteLine("Enter your name, please:");
            // Now read the name entered.
            string name = Console.ReadLine();
            // Greet the user with the name that was entered.
            Console.WriteLine("Hello, " +name);
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            //Needed otherwise console closes fast before reading the answer
            Console.Read();
        }
    }
}
