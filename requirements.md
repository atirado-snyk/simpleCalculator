# Simple Calculator Requirements

## Project Overview

This document outlines the requirements for a simple command-line calculator application. 

The calculator provides a text-based interface for performing mathematical calculations.

## Features

-   Performs mathematical operations on a list of values.
-   Accepts text prompts as input.
-   Recognizes mathematical constants like pi, e, and phi.
-   Performs mathematical operations on simple equations like sin(30) * 10
-   Provides error handling for invalid input and mathematical errors.
-   Includes a suite of unit tests to verify functionality.

## Operations

The calculator supports the same operations provided by supporting mathemtical library mentioned below.

## Constants

The calculator recognizes the following mathematical constants:

-   `pi`: The mathematical constant π.
-   `e`: The mathematical constant e (Euler's number).

## Tech Stack

The calculator is built using:

- Programming language: Python
- Parsing and processing mathematical expressions: py-expression-eval
- Regex-based user input validation
- Unit test framework: unittest

## Error Handling

The calculator provides the following error handling:

-   **Invalid Input**: If the input format is invalid, the calculator will display an error message.
-   **Invalid Operation**: If the operation is not supported, the calculator will display an error message.
-   **Invalid Number**: If a non-numeric value is provided, the calculator will display an error message.
-   **Division by Zero**: If a division by zero is attempted, the calculator will display an error message.
-   **Factorial of a Negative Number**: If a factorial of a negative number is attempted, the calculator will display an error message.

## Unit Tests

Create a suite of unit tests to verify the functionality of the calculator. The tests cover all the supported operations, constants, and error handling scenarios.
