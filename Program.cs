using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator!");
            Console.WriteLine("You can enter expressions like 'Add 2,3,4' or 'Subtract 1,2,3,4'.");
            Console.WriteLine("Enter 'exit' to quit.");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                try
                {
                    double result = Calculator.Evaluate(input);
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
