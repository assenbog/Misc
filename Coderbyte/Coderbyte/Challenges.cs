namespace Coderbyte
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text.RegularExpressions;

    public static class Challenges
    {
        // Find the [first, if multiple] longest word
        public static string GetLongestWord(string input)
        {
            var words = Regex.Split(input, @"\W");

            var longestWord = from word in words
                              group word by word.Length into wordGroups
                              orderby wordGroups.Key descending
                              select wordGroups.First();

            return longestWord.First();
        }

        // Calculate factorial for a given number
        public static int GetFactorial(int number)
        {
            var factorialRange = new List<int>();

            while (number > 1)
            {
                factorialRange.Add(number--);
            }

            return factorialRange.Aggregate(1, (acc, val) => acc * val);
        }

        // Reverse a string
        public static string GetReverseString(string str)
        {
            var stringArray = str.ToCharArray();

            Array.Reverse(stringArray);

            return new string(stringArray);
        }

        // In a given string replace all chars with the subsequent one in the alphabet (z -> a) and uppercase all vowels
        public static string GetCharReplacement(string str)
        {
            var chrArray = str.ToCharArray();
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };

            for (var i = 0; i < chrArray.Length; i++)
            {
                if (chrArray[i] == 'z')
                {
                    chrArray[i] = 'a';
                }
                else if (chrArray[i] == 'Z')
                {
                    chrArray[i] = 'A';
                }
                else if (chrArray[i] >= 'a' && chrArray[i] < 'z' || chrArray[i] >= 'A' && chrArray[i] < 'Z')
                {
                    chrArray[i]++;
                }
                if (vowels.Contains(chrArray[i]))
                {
                    chrArray[i] = char.ToUpper(chrArray[i]);
                }
            }
            return new string(chrArray);
        }

        public static int SimpleAdding(int num)
        {
            var numList = new List<int>();

            while (num > 0)
            {
                numList.Add(num--);
            }

            return numList.Sum();
        }

        public static string LetterCapitalise(string str)
        {
            return Regex.Replace(str, @"(\w+)", m => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(m.Value));
        }

        public static string IsPlusEnclosed(string str)
        {
            return Regex.IsMatch(str, @"[a-zA-Z]{1}(?!\++)|(?<!\++)[a-zA-Z]{1}") ? "false" : "true";
        }

        public static List<int> GetPrimes(int start, int end)
        {
            var primes = new List<int>();

            for (var i = 1; i <= end; i++)
            {
                if (primes.Where(prime => prime != 1).Any(prime => i % prime == 0))
                {
                    continue;
                }
                primes.Add(i);
            }

            return primes.Where(p => p >= start && p < end).ToList() ;
        }

        public static List<int> GetFibbonachi(int count)
        {
            var fibbonachiNumbers = new List<int> { 1, 1 };

            while (fibbonachiNumbers.Count() < count)
            {
                var nextNumber = fibbonachiNumbers.Skip(fibbonachiNumbers.Count - 2).Sum();
                fibbonachiNumbers.Add(nextNumber);
            }

            return fibbonachiNumbers;
        }

        public static int MaximumSquare(string[] strArr)
        {
            var oneRowMatchesList = new List<List<Match>>();

            var squareSizes = new List<int>();

            foreach(var str in strArr)
            {
                var match = Regex.Match(str, @"(1{2,})");

                var matches = new List<Match>();

                while(match.Success)
                {
                    matches.Add(match);

                    match = match.NextMatch();
                }

                oneRowMatchesList.Add(matches);
            }

            if(!oneRowMatchesList.Any())
            {
                // All zeros
                return 0;
            }

            var maxSquareSize = 1;

            var alreadyProcessed = new List<List<Match>>();

            foreach (var oneRowMatches in oneRowMatchesList)
            {
                alreadyProcessed.Add(oneRowMatches);

                var currentRowIndex = oneRowMatchesList.IndexOf(oneRowMatches);

                foreach(var oneRowMatch in oneRowMatches)
                {
                    var overlapLengths = new List<int>();
                    var overlapRowCount = 1;

                    foreach (var oneRowMatchesSubset in oneRowMatchesList.Where(p => !alreadyProcessed.Contains(p)))
                    {
                        var compareRowIndex = oneRowMatchesList.IndexOf(oneRowMatchesSubset);

                        if (compareRowIndex > currentRowIndex + overlapRowCount)
                        {
                            // When there's a gap we can stop checking further
                            break;
                        }

                        foreach (var oneRowMatchSubset in oneRowMatchesSubset)
                        {
                            // Leave the comparison loop first time the overlapping breaks
                            if(!MatchesOverlap(oneRowMatch, oneRowMatchSubset, out int overlapLength) || overlapLength < 2)
                            {
                                continue;
                            }
                            overlapRowCount++;
                            overlapLengths.Add(overlapLength);
                        }
                    }

                    if (!overlapLengths.Any())
                    {
                        continue;
                    }

                    var minOverlapLength = Math.Min(overlapLengths.Min(), overlapLengths.Count + 1);

                    if (minOverlapLength > maxSquareSize)
                    {
                        maxSquareSize = minOverlapLength;
                    }
                }
            }

            return maxSquareSize * maxSquareSize;
        }

        static bool MatchesOverlap(Match match1, Match match2, out int overlapLength)
        {
            bool returnValue;

            var match1StartIndex = match1.Index;
            var match2StartIndex = match2.Index;

            var match1EndIndex = match1.Index + match1.Length - 1;
            var match2EndIndex = match2.Index + match2.Length - 1;

            // We have 4 overlapping scenarios:
            // 1 - match1 contains match2 entirely
            // 2 - match2 contains match1 entirely
            // 3 - match1 and match2 partially overlap, with match1 being left of match2
            // 4 - match1 and match2 partially overlap, with match2 being left of match1
            // 5 - no overlapping

            // Scenario 1
            if (match1StartIndex <= match2StartIndex && match1EndIndex >= match2EndIndex)
            {
                returnValue = true;
                overlapLength = match2.Length;
            }
            // Scenario 2
            else if (match2StartIndex <= match1StartIndex && match2EndIndex >= match1EndIndex)
            {
                returnValue = true;
                overlapLength = match1.Length;
            }
            // Scenario 3
            else if (match1StartIndex < match2StartIndex && match1EndIndex < match2EndIndex)
            {
                returnValue = true;
                overlapLength = match1EndIndex - match2StartIndex + 1;
            }
            // Scenario 4
            else if (match2StartIndex < match1StartIndex && match2EndIndex < match1EndIndex)
            {
                returnValue = true;
                overlapLength = match2EndIndex - match1StartIndex + 1;
            }
            // Scenario 5
            else
            {
                returnValue = false;
                overlapLength = 0;
            }

            return returnValue;
        }

        public static int PentagonalNumber(int num)
        {
            var totalPoints = 0;

            while(num > 1)
            {
                totalPoints += num-- * 5 - 5;
            }

            return totalPoints + 1;
        }

        public static string QuestionsMarks(string str)
        {
            var returnValue = true;
            var atLeastOnePairAddsUpTo10 = false;

            var matches = Regex.Matches(str, @"(?<=(\d{1}))(.+?)(\d{1})");

            foreach(var match in matches.Cast<Match>())
            {
                var startDigit = int.Parse(match.Groups[1].Value.ToString());
                var endDigit = int.Parse(match.Groups[3].Value.ToString());

                var numberOfQuestionMarks = match.Groups[2].Value.ToCharArray().Count(p => p == '?');

                if(startDigit + endDigit == 10)
                {
                    atLeastOnePairAddsUpTo10 = true;
                    if (numberOfQuestionMarks != 3)
                    {
                        returnValue = false;
                        break;
                    }
                }
            }

            return (returnValue & atLeastOnePairAddsUpTo10).ToString().ToLower();
        }

        public static string AlphabetSoup(string str)
        {
            var orderedCharArray = str.ToCharArray().OrderBy(p => p).ToArray();

            return new string(orderedCharArray);
        }

        public static int KaprekarsConstant(int num)
        {
            var counter = 1;

            var prevStep = KaprekarsDifference(num);

            while(true)
            {
                var nextStep = KaprekarsDifference(prevStep);

                if(prevStep == nextStep)
                {
                    break;
                }

                counter++;

                prevStep = nextStep;
            }

            return counter;
        }

        private static int KaprekarsDifference(int num)
        {
            var ascendingArray = num.ToString().ToCharArray().OrderBy(p => p).ToArray();
            var descendingArray = num.ToString().ToCharArray().OrderByDescending(p => p).ToArray();

            var zeros = new string('0', 4 - descendingArray.Length)?.ToCharArray();

            if (zeros.Any())
            {
                descendingArray = descendingArray.Concat(zeros).ToArray();
            }

            var ascendingOrder = new string(ascendingArray);
            var descendingOrder = new string(descendingArray);

            var ascendingNumberSuccess = int.TryParse(ascendingOrder, out int ascendingNumber);
            var descendingNumberSuccess = int.TryParse(descendingOrder, out int descendingNumber);

            if(ascendingNumberSuccess && descendingNumberSuccess)
            {
                return descendingNumber - ascendingNumber;
            }

            return 0;
        }

        public static int ChessboardTraveling(string str)
        {
            var match = Regex.Match(str, @"\((\d{1}) (\d{1})\)\((\d{1}) (\d{1})\)");

            var count = 0;

            if (match.Success)
            {
                var startRow = int.Parse(match.Groups[1].ToString());
                var startCol = int.Parse(match.Groups[2].ToString());

                var chessMove = new ChessMoves(startRow, startCol);

                var endRow = int.Parse(match.Groups[3].ToString());
                var endCol = int.Parse(match.Groups[4].ToString());

                chessMove.PathsToCell(endRow, endCol, ref count);
            }

            return count;
        }
    }
}
