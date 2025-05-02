using System;

namespace MathOperationApp
{
    // Create a class named MathOps
    class MathOps
    {
        // Create a void method that takes two integers as parameters
        public void PerformOperation(int number1, int number2)
        {
            // Perform a math operation (e.g., multiply the first number by 2)
            int result = number1 * 2;

            // Display the result of the math operation
            Console.WriteLine("The result of the math operation on the first number is: " + result);

            // Display the second number
            Console.WriteLine("The second number is: " + number2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOps class
            MathOps mathOps = new MathOps();

            // Call the method by passing two numbers directly
            mathOps.PerformOperation(5, 10);

            // Call the method by naming the parameters
            mathOps.PerformOperation(number1: 7, number2: 3);

            // Prevent the console from closing immediately
            Console.ReadLine();
        }
    }
}
