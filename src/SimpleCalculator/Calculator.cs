using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace SimpleCalculator
{
    public class Calculator
    {
        private static readonly Dictionary<string, double> Constants = new Dictionary<string, double>
        {
            { "pi", Math.PI },
            { "e", Math.E },
            { "phi", (1 + Math.Sqrt(5)) / 2 }
        };

        public string Evaluate(string input)
        {
            input = input.Trim();

            // Handle constants
            if (Constants.ContainsKey(input.ToLower()))
            {
                return Constants[input.ToLower()].ToString();
            }

            // Handle operations
            Match match = Regex.Match(input, @"^([a-zA-Z]+)\s+(.*)$");
            if (match.Success)
            {
                string operation = match.Groups[1].Value;
                string arguments = match.Groups[2].Value;

                switch (operation.ToLower())
                {
                    case "add":
                        return Add(arguments);
                    case "subtract":
                        return Subtract(arguments);
                    case "multiply":
                        return Multiply(arguments);
                    case "divide":
                        return Divide(arguments);
                    case "power":
                        return Power(arguments);
                    case "factorial":
                        return Factorial(arguments);
                    case "abs":
                        return Abs(arguments);
                    case "log":
                        return Log(arguments);
                    case "alog":
                        return Alog(arguments);
                    case "sin":
                        return Sin(arguments);
                    case "cos":
                        return Cos(arguments);
                    case "tan":
                        return Tan(arguments);
                    case "asin":
                        return Asin(arguments);
                    case "acos":
                        return Acos(arguments);
                    case "atan":
                        return Atan(arguments);
                    default:
                        throw new ArgumentException("Invalid operation.");
                }
            }

            // Handle mathematical expressions using Roslyn
            try
            {
                // Prepare the script:
                // 1. Replace constants with their numerical values
                // 2. Prefix common math functions with "Math."
                string script = input;
                foreach (var constant in Constants)
                {
                    script = Regex.Replace(script, $@"\b{constant.Key}\b", constant.Value.ToString(), RegexOptions.IgnoreCase);
                }
                
                // List of common Math functions to prefix
                string[] mathFunctions = { "sin", "cos", "tan", "asin", "acos", "atan", "log", "pow", "abs", "sqrt", "round", "floor", "ceiling" };
                foreach (string func in mathFunctions)
                {
                    script = Regex.Replace(script, $@"\b{func}\(", $"Math.{func}(", RegexOptions.IgnoreCase);
                }

                var options = ScriptOptions.Default.WithImports("System.Math");
                var result = CSharpScript.EvaluateAsync<double>(script, options).Result;
                return result.ToString();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Invalid mathematical expression or syntax error.", ex);
            }
        }
        private List<double> ParseNumbers(string args, int expectedCount = -1)
        {
            List<double> numbers = args.Split(',')
                                      .Select(s => {
                                          s = s.Trim();
                                          if (Constants.ContainsKey(s.ToLower()))
                                          {
                                              return Constants[s.ToLower()];
                                          }
                                          if (!double.TryParse(s, out double num))
                                          {
                                              throw new ArgumentException($"Invalid number provided: {s}");
                                          }
                                          return num;
                                      })
                                      .ToList();

            if (expectedCount != -1 && numbers.Count != expectedCount)
            {
                throw new ArgumentException($"Operation requires exactly {expectedCount} arguments, but {numbers.Count} were provided.");
            }
            return numbers;
        }

        private string Add(string args)
        {
            List<double> numbers = ParseNumbers(args);
            return numbers.Sum().ToString();
        }

        private string Subtract(string args)
        {
            List<double> numbers = ParseNumbers(args);
            if (numbers.Count < 2)
            {
                throw new ArgumentException("Subtract operation requires at least two numbers.");
            }
            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result -= numbers[i];
            }
            return result.ToString();
        }

        private string Multiply(string args)
        {
            List<double> numbers = ParseNumbers(args);
            double result = 1;
            foreach (double num in numbers)
            {
                result *= num;
            }
            return result.ToString();
        }

        private string Divide(string args)
        {
            List<double> numbers = ParseNumbers(args);
            if (numbers.Count < 2)
            {
                throw new ArgumentException("Divide operation requires at least two numbers.");
            }
            if (numbers.Any(n => n == 0))
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }
            double result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result /= numbers[i];
            }
            return result.ToString();
        }

        private string Power(string args)
        {
            List<double> numbers = ParseNumbers(args, 2);
            return Math.Pow(numbers[0], numbers[1]).ToString();
        }

        private string Factorial(string args)
        {
            double num = ParseNumbers(args, 1)[0];
            if (num < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            if (num % 1 != 0)
            {
                throw new ArgumentException("Factorial is only defined for non-negative integers.");
            }
            long result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result.ToString();
        }

        private string Abs(string args)
        {
            double num = ParseNumbers(args, 1)[0];
            return Math.Abs(num).ToString();
        }

        private string Log(string args)
        {
            List<double> numbers = ParseNumbers(args);
            if (numbers.Count == 1)
            {
                return Math.Log(numbers[0]).ToString(); // Natural log
            }
            else if (numbers.Count == 2)
            {
                return Math.Log(numbers[0], numbers[1]).ToString();
            }
            else
            {
                throw new ArgumentException("Log operation requires one or two arguments (number, [base]).");
            }
        }

        private string Alog(string args)
        {
            List<double> numbers = ParseNumbers(args);
            if (numbers.Count == 1)
            {
                return Math.Pow(10, numbers[0]).ToString(); // Base 10 antilog
            }
            else if (numbers.Count == 2)
            {
                return Math.Pow(numbers[1], numbers[0]).ToString(); // base ^ number
            }
            else
            {
                throw new ArgumentException("Alog operation requires one or two arguments (number, [base]).");
            }
        }

        private string Sin(string args)
        {
            double num = ParseNumbers(args, 1)[0];
            return Math.Sin(num).ToString();
        }

        private string Cos(string args)
        {
            double num = ParseNumbers(args, 1)[0];
            return Math.Cos(num).ToString();
        }

        private string Tan(string args)
        {
            double num = ParseNumbers(args, 1)[0];
            return Math.Tan(num).ToString();
        }

        private string Asin(string args)
        {
            double num = ParseNumbers(args, 1)[0];
            return Math.Asin(num).ToString();
        }

        private string Acos(string args)
        {
            double num = ParseNumbers(args, 1)[0];
            return Math.Acos(num).ToString();
        }

        private string Atan(string args)
        {
            double num = ParseNumbers(args, 1)[0];
            return Math.Atan(num).ToString();
        }
    }
}
