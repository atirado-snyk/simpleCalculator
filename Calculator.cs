using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public static class Calculator
    {
        public static double Evaluate(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be empty.");
            }

            var regex = new Regex(@"^(?<operation>\w+)\s+(?<values>[\d,.-]+)$", RegexOptions.IgnoreCase);
            var match = regex.Match(input);

            if (!match.Success || string.IsNullOrWhiteSpace(match.Groups["operation"].Value) || string.IsNullOrWhiteSpace(match.Groups["values"].Value))
            {
                throw new ArgumentException("Invalid input format.");
            }

            string operation = match.Groups["operation"].Value.ToLower();
            string[] stringValues = match.Groups["values"].Value.Split(',');


            if (stringValues.Length == 0)
            {
                throw new ArgumentException("No values provided for the operation.");
            }

            List<double> values = new List<double>();
            foreach (var stringValue in stringValues)
            {
                string trimmedValue = stringValue.Trim().ToLower();
                if (trimmedValue == "pi")
                {
                    values.Add(Math.PI);
                }
                else if (trimmedValue == "e")
                {
                    values.Add(Math.E);
                }
                else if (double.TryParse(trimmedValue, out double value))
                {
                    values.Add(value);
                }
                else
                {
                    throw new ArgumentException($"Invalid number: {stringValue}");
                }
            }

            switch (operation)
            {
                case "add":
                    return values.Sum();
                case "subtract":
                    return values.Aggregate((a, b) => a - b);
                case "multiply":
                    return values.Aggregate((a, b) => a * b);
                case "divide":
                    return values.Aggregate((a, b) =>
                    {
                        if (b == 0)
                        {
                            throw new DivideByZeroException("Cannot divide by zero.");
                        }
                        return a / b;
                    });
                case "power":
                    return Math.Pow(values[0], values[1]);
                case "factorial":
                    if (values[0] < 0)
                    {
                        throw new ArgumentException("Factorial is not defined for negative numbers.");
                    }
                    if (values[0] > 20)
                    {
                        throw new ArgumentException("Factorial is not supported for numbers greater than 20.");
                    }
                    return Enumerable.Range(1, (int)values[0]).Aggregate(1, (p, item) => p * item);
                case "abs":
                    return Math.Abs(values[0]);
                case "log":
                    return Math.Log(values[0], values.Count > 1 ? values[1] : Math.E);
                case "alog":
                    return Math.Pow(values.Count > 1 ? values[1] : 10, values[0]);
                case "sin":
                    return Math.Sin(values[0]);
                case "cos":
                    return Math.Cos(values[0]);
                case "tan":
                    return Math.Tan(values[0]);
                case "asin":
                    return Math.Asin(values[0]);
                case "acos":
                    return Math.Acos(values[0]);
                case "atan":
                    return Math.Atan(values[0]);
                case "sqrt":
                case "squaredroot":
                    return Math.Sqrt(values[0]);
                case "cbrt":
                case "cubedroot":
                    return Math.Cbrt(values[0]);
                default:
                    throw new ArgumentException($"Invalid operation: {operation}");
            }
        }
    }
}
