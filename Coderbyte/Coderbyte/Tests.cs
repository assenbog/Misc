namespace Coderbyte
{
    using NUnit.Framework;
    using System.Linq;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void LongestWordTest1()
        {
            const string sentence = "A walk in the park";
            const string firstLongestWord = "walk";

            var longestWord = Challenges.GetLongestWord(sentence);

            Assert.AreEqual(longestWord, firstLongestWord);
        }

        [Test]
        public void LongestWordTest2()
        {
            const string sentence = "fee fi fo fum";
            const string firstLongestWord = "fee";

            var longestWord = Challenges.GetLongestWord(sentence);

            Assert.AreEqual(longestWord, firstLongestWord);
        }

        [Test]
        public void FactorialTest()
        {
            const int number = 5;
            const int factorialValue = 120;

            var factorial = Challenges.GetFactorial(number);

            Assert.AreEqual(factorialValue, factorial);
        }

        [Test]
        public void ReverseStringTest()
        {
            const string text = "abracadabra";
            const string arbacadabraInReverse = "arbadacarba";

            var reverseString = Challenges.GetReverseString(text);

            Assert.AreEqual(reverseString, arbacadabraInReverse);
        }

        [Test]
        public void CharReplacementTest()
        {
            const string text = "abracadabra";
            const string textReplacement = "bcsbdbEbcsb";

            var result = Challenges.GetCharReplacement(text);

            Assert.AreEqual(result, textReplacement);
        }

        [Test]
        public void SimpleAddingTest()
        {
            const int number = 5;
            const int sumValue = 15;

            var sum = Challenges.SimpleAdding(number);

            Assert.AreEqual(sum, sumValue);
        }

        [Test]
        public void WordCapitaliseTest()
        {
            const string sentence = "fee fi fo fum";
            const string wordCapitalise = "Fee Fi Fo Fum";

            var result = Challenges.LetterCapitalise(sentence);

            Assert.AreEqual(result, wordCapitalise);
        }

        [Test]
        public void PlusEnclosedTest1()
        {
            const string text = "+b++a==+s+c";

            Assert.AreEqual("false", Challenges.IsPlusEnclosed(text));
        }

        [Test]
        public void PlusEnclosedTest2()
        {
            const string text = "+b++a+=+s+c+";

            Assert.AreEqual("true", Challenges.IsPlusEnclosed(text));
        }

        [Test]
        public void FibbonachiTest()
        {
            var fibbonachiNumbers = new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };

            Assert.IsTrue(Challenges.GetFibbonachi(11).All(p => fibbonachiNumbers.Contains(p)));
        }

        [Test]
        public void PrimesTest()
        {
            var primeNumbers = new[] { 5, 7, 11, 13, 17, 19 };

            Assert.IsTrue(Challenges.GetPrimes(4, 20).All(p => primeNumbers.Contains(p)));
        }
    }
}
