# calculator.py

import math
from py_expression_eval import Parser

class Calculator:
    def __init__(self):
        self.parser = Parser()
        self.vars = {
            'pi': math.pi,
            'e': math.e,
            'phi': (1 + math.sqrt(5)) / 2
        }

    def evaluate(self, expression):
        try:
            result = self.parser.parse(expression).evaluate(self.vars)
            return result
        except Exception as e:
            return f"Error: {e}"

if __name__ == "__main__":
    calculator = Calculator()
    print("Simple Calculator. Type 'exit' to quit.")
    while True:
        user_input = input("> ")
        if user_input.lower() == 'exit':
            break
        if user_input:
            result = calculator.evaluate(user_input)
            print(result)
