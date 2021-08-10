using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DHDistinctionTask;
using AdvanceMaths;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        CalcFunctions _calFunc = new CalcFunctions();
        CalculatorFunctions2 _advFunc = new CalculatorFunctions2();

        [TestMethod]
        public void TestAddMethod()
        {
            int a = 10;
            int b = 30;
            int expected = 40;
            int actual = _calFunc.Add(a, b);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestSubstractMethod()
        {
            int a = 100;
            int b = 50;
            int expected = 50;
            int actual = _calFunc.Substract(a, b);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            int a = 50;
            int b = 50;
            int expected = 2500;
            int actual = _calFunc.Multiply(a, b);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestDivideMethod()
        {
            int a = 300;
            int b = 50;
            int expected = 6;
            int actual = _calFunc.Divide(a, b);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestPowerMethod()
        {
            int a = 10;
            int b = 2;
            double expected = 100;
            double actual = _advFunc.Power(a, b);
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void TestRootMethod()
        {
            int a = 100;
            double expected = 10;
            double actual = _advFunc.SquareRoot(a);
            Assert.AreEqual(actual, expected);
        }
    }
}
