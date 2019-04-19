namespace RPN.Tests
{
    using NUnit.Framework;
    using RPN.Utilities;

    [TestFixture]
    public class RegExTests
    {
        [Test]
        public void IntSimpleTest()
        {
            var expression = @"(123+";
            var target = "123";
            var matchIndex = 1;

            var number = ExpressionRegex.GetNextNumber(expression);

            Assert.AreEqual(number.Item1, target);
            Assert.AreEqual(number.Item2, matchIndex);
        }

        [Test]
        public void DecimalSimpleTest()
        {
            var expression = @" (123.456+";
            var target = "123.456";
            var matchIndex = 2;

            var number = ExpressionRegex.GetNextNumber(expression);

            Assert.AreEqual(number.Item1, target);
            Assert.AreEqual(number.Item2, matchIndex);
        }

        [Test]
        public void ScientificNotationSimpleTest()
        {
            var expression = @"(1.23456e10+";
            var target = "1.23456e10";
            var matchIndex = 1;

            var number = ExpressionRegex.GetNextNumber(expression);

            Assert.AreEqual(number.Item1, target);
            Assert.AreEqual(number.Item2, matchIndex);
        }

        [Test]
        public void ScientificNotationTest1()
        {
            var expression = @"(.23456e10+";
            var target = ".23456e10";
            var matchIndex = 1;

            var number = ExpressionRegex.GetNextNumber(expression);

            Assert.AreEqual(number.Item1, target);
            Assert.AreEqual(number.Item2, matchIndex);
        }

        [Test]
        public void ScientificNotationTest2()
        {
            var expression = @"(.23456E-10+";
            var target = ".23456E-10";
            var matchIndex = 1;

            var number = ExpressionRegex.GetNextNumber(expression);

            Assert.AreEqual(number.Item1, target);
            Assert.AreEqual(number.Item2, matchIndex);
        }

        [Test]
        public void OperandTest1()
        {
            var expression = @" +.23456E-10+";
            var target = "+";
            var matchIndex = 1;

            var operand = ExpressionRegex.GetNextOperand(expression);

            Assert.AreEqual(operand.Item1, target);
            Assert.AreEqual(operand.Item2, matchIndex);
        }

        [Test]
        public void OperandTest2()
        {
            var expression = @"5-3";
            var target = "-";
            var matchIndex = 1;

            var operand = ExpressionRegex.GetNextOperand(expression);

            Assert.AreEqual(operand.Item1, target);
            Assert.AreEqual(operand.Item2, matchIndex);
        }

        [Test]
        public void OperandTest3()
        {
            var expression = @"6/3";
            var target = "/";
            var matchIndex = 1;

            var operand = ExpressionRegex.GetNextOperand(expression);

            Assert.AreEqual(operand.Item1, target);
            Assert.AreEqual(operand.Item2, matchIndex);
        }

        [Test]
        public void OperandTest4()
        {
            var expression = @"2^10";
            var target = "^";
            var matchIndex = 1;

            var operand = ExpressionRegex.GetNextOperand(expression);

            Assert.AreEqual(operand.Item1, target);
            Assert.AreEqual(operand.Item2, matchIndex);
        }

        [Test]
        public void OperandTest5()
        {
            var expression = @"2*3";
            var target = "*";
            var matchIndex = 1;

            var operand = ExpressionRegex.GetNextOperand(expression);

            Assert.AreEqual(operand.Item1, target);
            Assert.AreEqual(operand.Item2, matchIndex);
        }

        [Test]
        public void OperandMathFunctionTest1()
        {
            var expression = @"2+sin(45)";
            var target = "sin";
            var matchIndex = 2;

            var operand = ExpressionRegex.GetNextMathFunction(expression);

            Assert.AreEqual(operand.Item1, target);
            Assert.AreEqual(operand.Item2, matchIndex);
        }

        [Test]
        public void OperandMathFunctionTest2()
        {
            var expression = @"abs(-1)";
            var target = "abs";
            var matchIndex = 0;

            var operand = ExpressionRegex.GetNextMathFunction(expression);

            Assert.AreEqual(operand.Item1, target);
            Assert.AreEqual(operand.Item2, matchIndex);
        }
    }
}
