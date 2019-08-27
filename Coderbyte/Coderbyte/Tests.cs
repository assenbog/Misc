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

        [Test]
        public void MaxSquareTest1()
        {
            var matrix = new[]
            {
                "10100",
                "10111",
                "11111",
                "10010"
            };

            Assert.AreEqual(Challenges.MaximumSquare(matrix), 4);
        }

        [Test]
        public void MaxSquareTest2()
        {
            var matrix = new[]
            {
                "1010011",
                "1011100",
                "1111101",
                "1011111"
            };

            Assert.AreEqual(Challenges.MaximumSquare(matrix), 9);
        }

        [Test]
        public void MaxSquareTest3()
        {
            var matrix = new[]
            {
                "101001111",
                "101001111",
                "101101111",
                "111001111",
                "111110101",
                "111111101"
            };

            Assert.AreEqual(Challenges.MaximumSquare(matrix), 16);
        }

        [Test]
        public void MaxSquareTest4()
        {
            var matrix = new[]
            {
                "0111",
                "1101",
                "0111"
            };

            Assert.AreEqual(Challenges.MaximumSquare(matrix), 1);
        }

        [Test]
        public void PentagonalNumberTest1()
        {
            const int number = 2;
            const int sumValue = 6;

            var sum = Challenges.PentagonalNumber(number);

            Assert.AreEqual(sum, sumValue);
        }

        [Test]
        public void PentagonalNumberTest2()
        {
            const int number = 5;
            const int sumValue = 51;

            var sum = Challenges.PentagonalNumber(number);

            Assert.AreEqual(sum, sumValue);
        }

        [Test]
        public void QuestionsMarksTest1()
        {
            const string text = "acc?7??sss?3rr1??????5";

            Assert.AreEqual("true", Challenges.QuestionsMarks(text));
        }

        [Test]
        public void QuestionsMarksTest2()
        {
            const string text = "aa6?9";

            Assert.AreEqual("false", Challenges.QuestionsMarks(text));
        }

        [Test]
        public void QuestionsMarksTest3()
        {
            const string text = "5??aaaaaaaaaaaaaaaaaaa?5?5";

            Assert.AreEqual("false", Challenges.QuestionsMarks(text));
        }

        [Test]
        public void AlphabetSoupTest1()
        {
            const string text = "coderbyte";

            Assert.AreEqual("bcdeeorty", Challenges.AlphabetSoup(text));
        }

        [Test]
        public void KaprekarsDifferenceTest1()
        {
            const int number = 3524;
            const int iterations = 3;

            Assert.AreEqual(iterations, Challenges.KaprekarsConstant(number));
        }

        [Test]
        public void KaprekarsDifferenceTest2()
        {
            const int number = 2111;
            const int iterations = 5;

            Assert.AreEqual(iterations, Challenges.KaprekarsConstant(number));
        }

        [Test]
        public void ChessboardTravelingTest1()
        {
            const string text = "(2 2)(4 3)";

            Assert.AreEqual(3, Challenges.ChessboardTraveling(text));
        }

        [Test]
        public void ChessboardTravelingTest2()
        {
            const string text = "(1 1)(3 3)";

            Assert.AreEqual(6, Challenges.ChessboardTraveling(text));
        }
    }
}
