using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Taking a  First number from user
            Console.WriteLine("Enter first number");

            // Reads a string and converts to Integer
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Taking a second number from user
            Console.WriteLine("Enter second number");

            // Reads the input as a string and converts to integer
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Taking opearator as input from user
            Console.WriteLine("Enter the operator:(+, -, /, *)");

            // Returns a String
            string op = Console.ReadLine();

            if (op == "+")
            {
                // Assigning the sum of (num1+num2) in sum variable
                int sum = num1 + num2;
                // Printing the sum of (num1 + num2)
                Console.WriteLine("Sum is {0},", sum);
            }
            else if (op == "-")
            {
                // Assigning the substraction of (num1,num2) in substraction variable
                int subtraction = num1 - num2;
                // Printing the substraction of (num1 - num2)
                Console.WriteLine("Substration is {0}", subtraction);
            }
            else if (op == "/")
            {
                // Assigning the division of (num1/num2) in division variable
                int division = num1 / num2;

                // Printing the division of (num1/num2)
                Console.WriteLine("Division is {0}", division);
            }
            else if (op == "*")

            {
                // Assigning the Multiplication of (num1*num2) in multiplication variable
                int multiplication = num1 * num2;

                // Printing the Multiplication of (num1 *  num2)
                Console.WriteLine("Multiplication is {0}", multiplication);
            }
            else
            {
                // Printing Invalid expression
                Console.WriteLine("Invalid Expression");
            }




        }
    }
}
