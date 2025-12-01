import unittest
import math
from calculator import Calculator

class TestCalculator(unittest.TestCase):

    def setUp(self):
        self.calculator = Calculator()

    def test_addition(self):
        self.assertEqual(self.calculator.evaluate("1 + 1"), 2)

    def test_subtraction(self):
        self.assertEqual(self.calculator.evaluate("5 - 3"), 2)

    def test_multiplication(self):
        self.assertEqual(self.calculator.evaluate("2 * 3"), 6)

    def test_division(self):
        self.assertEqual(self.calculator.evaluate("6 / 2"), 3)

    def test_constants(self):
        self.assertAlmostEqual(self.calculator.evaluate("pi"), math.pi)
        self.assertAlmostEqual(self.calculator.evaluate("e"), math.e)
        self.assertAlmostEqual(self.calculator.evaluate("phi"), (1 + math.sqrt(5)) / 2)

    def test_invalid_expression(self):
        self.assertTrue("Error" in self.calculator.evaluate("1 + "))

    def test_division_by_zero(self):
        self.assertTrue("Error" in self.calculator.evaluate("1 / 0"))

if __name__ == '__main__':
    unittest.main()
