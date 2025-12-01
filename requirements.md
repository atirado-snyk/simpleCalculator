# Simple Calculator Requirements

## Project Overview

This document outlines the requirements for a simple command-line calculator application. 

The calculator provides a text-based interface for performing mathematical calculations.

## Features

-   Performs mathematical operations on a list of values.
-   Accepts text prompts as input.
-   Recognizes mathematical constants like pi, e, phi.
-   Performs mathematical operations on simple equations like sin(x) * 10
-   Provides error handling for invalid input and mathematical errors.
-   Includes a suite of unit tests to verify functionality.

## Operations

The calculator supports the following mathematical operations:

| Operation | Syntax | Description |
| --- | --- | --- |
| Addition | `Add <n1>,<n2>,...` | Adds a list of numbers. |
| Subtraction | `Subtract <n1>,<n2>,...` | Subtracts a list of numbers. |
| Multiplication | `Multiply <n1>,<n2>,...` | Multiplies a list of numbers. |
| Division | `Divide <n1>,<n2>,...` | Divides a list of numbers. |
| Power | `Power <base>,<exponent>` | Raises a number to a power. |
| Factorial | `Factorial <n>` | Calculates the factorial of a number. |
| Absolute Value | `Abs <n>` | Calculates the absolute value of a number. |
| Logarithm | `Log <n>,[base]` | Calculates the logarithm of a number. Defaults to natural log. |
| Antilogarithm | `Alog <n>,[base]` | Calculates the antilogarithm of a number. Defaults to base 10. |
| Sine | `Sin <n>` | Calculates the sine of a number. |
| Cosine | `Cos <n>` | Calculates the cosine of a number. |
| Tangent | `Tan <n>` | Calculates the tangent of a number. |
| Arcsine | `Asin <n>` | Calculates the arcsine of a number. |
| Arccosine | `Acos <n>` | Calculates the arccosine of a number. |
| Arctangent | `Atan <n>` | Calculates the arctangent of a number. |

## Constants

The calculator recognizes the following mathematical constants:

-   `pi`: The mathematical constant π.
-   `e`: The mathematical constant e (Euler's number).
-   `phi`: The golden ratio

## Tech Stack

The calculator is built using:

- Programming language: Python
- Regex-based user input validation
- Unit test framework: unittest
- Scripting for mathematical expressions: py-expression-eval

## Error Handling

The calculator provides the following error handling:

-   **Invalid Input**: If the input format is invalid, the calculator will display an error message.
-   **Invalid Operation**: If the operation is not supported, the calculator will display an error message.
-   **Invalid Number**: If a non-numeric value is provided, the calculator will display an error message.
-   **Division by Zero**: If a division by zero is attempted, the calculator will display an error message.
-   **Factorial of a Negative Number**: If a factorial of a negative number is attempted, the calculator will display an error message.

## Unit Tests

Create a suite of unit tests to verify the functionality of the calculator. The tests cover all the supported operations, constants, and error handling scenarios.
