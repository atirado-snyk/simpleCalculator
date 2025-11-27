using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(9, Calculator.Evaluate("Add 2,3,4"));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual(-8, Calculator.Evaluate("Subtract 1,2,3,4"));
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Assert.AreEqual(24, Calculator.Evaluate("Multiply 2,3,4"));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(0.5, Calculator.Evaluate("Divide 4,2,4"));
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => Calculator.Evaluate("Divide 1,0"));
        }

        [TestMethod]
        public void TestInvalidOperation()
        {
            Assert.ThrowsException<ArgumentException>(() => Calculator.Evaluate("Unknown 1,2"));
        }

        [TestMethod]
        public void TestInvalidNumber()
        {
            Assert.ThrowsException<ArgumentException>(() => Calculator.Evaluate("Add 1,abc"));
        }

        [TestMethod]
        public void TestPower()
        {
            Assert.AreEqual(8, Calculator.Evaluate("Power 2,3"));
        }

        [TestMethod]
        public void TestFactorial()
        {
            Assert.AreEqual(120, Calculator.Evaluate("Factorial 5"));
        }

        [TestMethod]
        public void TestAbsoluteValue()
        {
            Assert.AreEqual(5, Calculator.Evaluate("Abs -5"));
        }

        [TestMethod]
        public void TestLog()
        {
            Assert.AreEqual(2, Calculator.Evaluate("Log 100,10"));
        }

        [TestMethod]
        public void TestNaturalLog()
        {
            Assert.AreEqual(1, Calculator.Evaluate("Log e"));
        }

        [TestMethod]
        public void TestAntilog()
        {
            Assert.AreEqual(100, Calculator.Evaluate("Alog 2"));
        }

        [TestMethod]
        public void TestSin()
        {
            Assert.AreEqual(0, Calculator.Evaluate("Sin 0"));
        }

        [TestMethod]
        public void TestCos()
        {
            Assert.AreEqual(1, Calculator.Evaluate("Cos 0"));
        }

        [TestMethod]
        public void TestTan()
        {
            Assert.AreEqual(0, Calculator.Evaluate("Tan 0"));
        }

        [TestMethod]
        public void TestAsin()
        {
            Assert.AreEqual(0, Calculator.Evaluate("Asin 0"));
        }

        [TestMethod]
        public void TestAcos()
        {
            Assert.AreEqual(Math.PI / 2, Calculator.Evaluate("Acos 0"));
        }

        [TestMethod]
        public void TestAtan()
        {
            Assert.AreEqual(0, Calculator.Evaluate("Atan 0"));
        }

        [TestMethod]
        public void TestSqrt()
        {
            Assert.AreEqual(4, Calculator.Evaluate("Sqrt 16"));
        }

        [TestMethod]
        public void TestCbrt()
        {
            Assert.AreEqual(3, Calculator.Evaluate("Cbrt 27"));
        }

        [TestMethod]
        public void TestPi()
        {
            Assert.AreEqual(Math.PI, Calculator.Evaluate("Add pi,0"));
        }

        [TestMethod]

        public void TestE()
        {
            Assert.AreEqual(Math.E, Calculator.Evaluate("Add e,0"));
        }

        [TestMethod]
        public void TestSquaredRoot()
        {
            Assert.AreEqual(4, Calculator.Evaluate("squaredroot 16"));
        }

        [TestMethod]
        public void TestCubedRoot()
        {
            Assert.AreEqual(3, Calculator.Evaluate("cubedroot 27"));
        }
    }
}
