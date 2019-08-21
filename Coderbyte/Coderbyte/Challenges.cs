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
    }
}
