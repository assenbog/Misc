namespace RPN.Tests
{
    using NUnit.Framework;
    using RPN.Utilities;

    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void ParsetTesti()
        {
            const string infixNotation = "3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3";
            const string target = "3 4 2 * 1 5 - 2 3 ^ ^ / +";

            var posfixNotation = Parser.ConvertToRPN(infixNotation);

            Assert.AreEqual(posfixNotation, target);
        }
    }
}
