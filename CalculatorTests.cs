using NUnit.Framework;
using System;

namespace SimpleCalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void TestAddition()
        {
            Assert.AreEqual(9, Calculator.Evaluate("Add 2,3,4"));
        }

        [Test]
        public void TestSubtraction()
        {
            Assert.AreEqual(-8, Calculator.Evaluate("Subtract 1,2,3,4"));
        }

        [Test]
        public void TestMultiplication()
        {
            Assert.AreEqual(24, Calculator.Evaluate("Multiply 2,3,4"));
        }

        [Test]
        public void TestDivision()
        {
            Assert.AreEqual(0.5, Calculator.Evaluate("Divide 4,2,4"));
        }

        [Test]
        public void TestDivisionByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Calculator.Evaluate("Divide 1,0"));
        }

        [Test]
        public void TestInvalidOperation()
        {
            Assert.Throws<ArgumentException>(() => Calculator.Evaluate("Unknown 1,2"));
        }

        [Test]
        public void TestInvalidNumber()
        {
            Assert.Throws<ArgumentException>(() => Calculator.Evaluate("Add 1,abc"));
        }

        [Test]
        public void TestPower()
        {
            Assert.AreEqual(8, Calculator.Evaluate("Power 2,3"));
        }

        [Test]
        public void TestFactorial()
        {
            Assert.AreEqual(120, Calculator.Evaluate("Factorial 5"));
        }

        [Test]
        public void TestAbsoluteValue()
        {
            Assert.AreEqual(5, Calculator.Evaluate("Abs -5"));
        }

        [Test]
        public void TestLog()
        {
            Assert.AreEqual(2, Calculator.Evaluate("Log 100,10"));
        }

        [Test]
        public void TestNaturalLog()
        {
            Assert.AreEqual(1, Calculator.Evaluate("Log e"));
        }

        [Test]
        public void TestAntilog()
        {
            Assert.AreEqual(100, Calculator.Evaluate("Alog 2"));
        }

        [Test]
        public void TestSin()
        {
            Assert.AreEqual(0, Calculator.Evaluate("Sin 0"));
        }

        [Test]
        public void TestCos()
        {
            Assert.AreEqual(1, Calculator.Evaluate("Cos 0"));
        }

        [Test]
        public void TestTan()
        {
            Assert.AreEqual(0, Calculator.Evaluate("Tan 0"));
        }

        [Test]
        public void TestAsin()
        {
            Assert.AreEqual(0, Calculator.Evaluate("Asin 0"));
        }

        [Test]
        public void TestAcos()
        {
            Assert.AreEqual(Math.PI / 2, Calculator.Evaluate("Acos 0"));
        }

        [Test]
        public void TestAtan()
        {
            Assert.AreEqual(0, Calculator.Evaluate("Atan 0"));
        }

        [Test]
        public void TestSqrt()
        {
            Assert.AreEqual(4, Calculator.Evaluate("Sqrt 16"));
        }

        [Test]
        public void TestCbrt()
        {
            Assert.AreEqual(3, Calculator.Evaluate("Cbrt 27"));
        }

        [Test]
        public void TestPi()
        {
            Assert.AreEqual(Math.PI, Calculator.Evaluate("Add pi,0"));
        }

        [Test]

        public void TestE()
        {
            Assert.AreEqual(Math.E, Calculator.Evaluate("Add e,0"));
        }

        [Test]
        public void TestSquaredRootOf()
        {
            Assert.AreEqual(4, Calculator.Evaluate("square root of 16"));
        }

        [Test]
        public void TestCubeRootOf()
        {
            Assert.AreEqual(3, Calculator.Evaluate("cube root of 27"));
        }
    }
}
