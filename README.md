# Simple Calculator

A command-line calculator application built in .NET C# that supports a variety of mathematical operations, constants, and expressions.

## Features

-   Performs mathematical operations on a list of values.
-   Accepts text prompts as input.
-   Recognizes mathematical constants like pi, e, phi.
-   Performs mathematical operations on simple equations like sin(x) * 10
-   Provides error handling for invalid input and mathematical errors.
-   Includes a suite of unit tests to verify functionality.

## Tech Stack

-   **Programming language:** .NET C#
-   **Regex-based user input validation**
-   **Unit test framework:** MSTest
-   **Scripting for mathematical expressions:** Roslyn

## How to Run

1.  **Clone the repository:**
    ```bash
    git clone https://github.com/snyk-demos/simple-calculator-snyk-training-sessions.git
    cd simple-calculator-snyk-training-sessions
    ```

2.  **Run the application:**
    ```bash
    dotnet run --project src/SimpleCalculator/SimpleCalculator.csproj
    ```

## How to Test

1.  **Run the tests:**
    ```bash
    dotnet test
    ```

## Usage

The calculator can be used in three ways:

1.  **Operations:** Enter an operation name followed by a space and a comma-separated list of numbers.
2.  **Constants:** Enter the name of a mathematical constant.
3.  **Expressions:** Enter a mathematical expression.

### Operations

| Operation        | Syntax                   | Description                                                 |
| ---------------- | ------------------------ | ----------------------------------------------------------- |
| Addition         | `Add <n1>,<n2>,...`      | Adds a list of numbers.                                     |
| Subtraction      | `Subtract <n1>,<n2>,...` | Subtracts a list of numbers.                                |
| Multiplication   | `Multiply <n1>,<n2>,...` | Multiplies a list of numbers.                               |
| Division         | `Divide <n1>,<n2>,...`   | Divides a list of numbers.                                  |
| Power            | `Power <base>,<exponent>`| Raises a number to a power.                                 |
| Factorial        | `Factorial <n>`          | Calculates the factorial of a number.                       |
| Absolute Value   | `Abs <n>`                | Calculates the absolute value of a number.                  |
| Logarithm        | `Log <n>,[base]`         | Calculates the logarithm of a number. Defaults to natural log. |
| Antilogarithm    | `Alog <n>,[base]`        | Calculates the antilogarithm of a number. Defaults to base 10.|
| Sine             | `Sin <n>`                | Calculates the sine of a number.                            |
| Cosine           | `Cos <n>`                | Calculates the cosine of a number.                          |
| Tangent          | `Tan <n>`                | Calculates the tangent of a number.                         |
| Arcsine          | `Asin <n>`               | Calculates the arcsine of a number.                         |
| Arccosine        | `Acos <n>`               | Calculates the arccosine of a number.                       |
| Arctangent       | `Atan <n>`               | Calculates the arctangent of a number.                      |

**Examples:**

```
> Add 1,2,3
Result: 6
> Power 2,3
Result: 8
> Log 100,10
Result: 2
```

### Constants

| Constant | Description                 |
| -------- | --------------------------- |
| `pi`     | The mathematical constant π |
| `e`      | Euler's number              |
| `phi`    | The golden ratio            |

**Example:**

```
> pi
Result: 3.141592653589793
```

### Expressions

The calculator can also evaluate mathematical expressions.

**Example:**

```
> (2 + 3) * 4
Result: 20
> sin(pi/2)
Result: 1
```
## License
This project is licensed under the terms of the MIT license.