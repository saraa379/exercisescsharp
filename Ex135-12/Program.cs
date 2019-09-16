using System;

namespace Ex135_12
{
    class Program
    {
        static void Main(string[] args) {
            /*A company dealing with marketing wants to keep a data record of its employees. Each record should have the 
             following characteristic – first name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). 
             Declare appropriate variables needed to maintain the information for an employee by using the appropriate data types and attribute names.*/
            /*public class Employee {
            /*
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public char Gender { get; set; }

            private static int nextEmployeeNumber = 27560000;
            private int employeeNumber;
            /*
            public void InitEmployee()
            {
                if (nextEmployeeNumber < 27569999) {
                    employeeNumber = ++nextEmployeeNumber;
                } else {
                    employeeNumber = nextEmployeeNumber;
                }

            }*/
            //}


            /*Ex13 - Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.*/
            int number1 = 5;
            int number2 = 10;
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("Number 1 is: " + number1);
            Console.WriteLine("Number 2 is: " + number2);

        }
    }
}

