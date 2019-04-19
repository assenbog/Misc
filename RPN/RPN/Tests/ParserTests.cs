namespace RPN.Tests
{
    using NUnit.Framework;
    using RPN.Utilities;

    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void ParsetTest1()
        {
            const string infixNotation = "3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3";
            const string target = "3 4 2 * 1 5 - 2 3 ^ ^ / +";

            var posfixNotation = Parser.ConvertToRPN(infixNotation);

            Assert.AreEqual(posfixNotation, target);
        }

        [Test]
        public void ParsetTest2()
        {
            const string infixNotation = "sin ( max ( 2, 3 ) / 3 * 3.1415916 )";
            const string target = "2 3 max 3 / 3.1415916 * sin";

            var posfixNotation = Parser.ConvertToRPN(infixNotation);

            Assert.AreEqual(posfixNotation, target);
        }
    }
}
