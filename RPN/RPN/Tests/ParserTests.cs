namespace RPN.Tests
{
    using NUnit.Framework;
    using RPN.Utilities;
    using System.Text;

    [TestFixture]
    public class ParserTests
    {
        [Test]
        public void ParsetTest1()
        {
            const string infixNotation = "3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3";
            const string target = "3 4 2 * 1 5 - 2 3 ^ ^ / +";

            var posfixNotationStack = Parser.ConvertToRPN(infixNotation);
            var sb = new StringBuilder();
            while(posfixNotationStack.Count > 0)
            {
                sb.Append($"{posfixNotationStack.Pop()} ");
            }

            Assert.AreEqual(sb.ToString().Trim(), target);
        }

        [Test]
        public void ParsetTest2()
        {
            const string infixNotation = "sin ( max ( 2, 3 ) / 3 * 3.1415916 )";
            const string target = "2 3 max 3 / 3.1415916 * sin";

            var posfixNotationStack = Parser.ConvertToRPN(infixNotation);
            var sb = new StringBuilder();
            while (posfixNotationStack.Count > 0)
            {
                sb.Append($"{posfixNotationStack.Pop()} ");
            }

            Assert.AreEqual(sb.ToString().Trim(), target);
        }
    }
}
