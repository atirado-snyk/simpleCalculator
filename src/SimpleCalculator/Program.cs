using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Enter an operation (e.g., Add 1,2,3), a mathematical expression (e.g., sin(pi/2)*10), a constant (e.g., pi) or 'exit' to quit.");

            Calculator calculator = new Calculator();

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "exit")
                {
                    break;
                }

                try
                {
                    string result = calculator.Evaluate(input);
                    Console.WriteLine($"Result: {result}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                }
            }
        }
    }
}

