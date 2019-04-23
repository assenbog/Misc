namespace RPN.Tests
{
    using System;
    using NUnit.Framework;
    using RPN.Utilities;

    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Test1()
        {
            const string expression = "(2 + 3) * 4";

            var calculatorResult = Calculator.Calculate(expression);

            Assert.AreEqual(calculatorResult, 20D);
        }

        [Test]
        public void Test2()
        {
            const string expression = "2 * 3 ^ 2";

            var calculatorResult = Calculator.Calculate(expression);

            Assert.AreEqual(calculatorResult, 18D);
        }

        [Test]
        public void Test3()
        {
            const string expression = "2 ^ (4+3*2)";

            var calculatorResult = Calculator.Calculate(expression);

            Assert.AreEqual(calculatorResult, 1024D);
        }

        [Test]
        public void Test4()
        {
            const string expression = "sin( 30)+ cos(60)";

            var calculatorResult = Calculator.Calculate(expression);

            Assert.AreEqual(calculatorResult, 1D);
        }
    }
}
