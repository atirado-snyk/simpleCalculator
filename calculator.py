# calculator.py

import math
import re
from py_expression_eval import Parser

class Calculator:
    def __init__(self):
        self.parser = Parser()
        self.vars = {
            'pi': math.pi,
            'e': math.e,
            'phi': (1 + math.sqrt(5)) / 2
        }

    def validate_expression(self, expression):
        # This regex is vulnerable to ReDoS
        pattern = re.compile(r'^([a-zA-Z0-9_]+\s*)+\s*$')
        if not pattern.match(expression):
            return False
        return True

    def evaluate(self, expression):
        try:
            if not self.validate_expression(expression):
                return "Error: Invalid expression"
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
