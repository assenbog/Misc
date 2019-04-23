namespace RPN.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public static class ExpressionRegex
    {
        private static readonly Regex numberRegEx;
        private static readonly Regex operandRegEx;
        private static readonly Regex mathFunctionsRegEx;
        private static readonly Regex whiteSpaceRegEx;

        static ExpressionRegex()
        {
            const string numberRegex = @".*?(\d*\.\d+E{1}[-+]?\d{1,3}|\d*\.\d+|\d+).*?";
            // Note: () are special types of operands
            const string operandRegex = @"\s*?\^|\*|\/|\+|\-|\)|\(";
            const string mathFunctionsRegex = @".*?(abs|sin|cos|tan|log|asin|acos|atan|sqrt|exp|max|min).*?";
            const string whiteSpaceRegex = @"\s*";

            FunctionArgumentCount = new Dictionary<string, int>
            {
                { "abs", 1 },
                { "cos", 1 },
                { "sin", 1 },
                { "tan", 1 },
                { "log", 1 },
                { "acos", 1 },
                { "asin", 1 },
                { "atan", 1 },
                { "sqrt", 1 },
                { "exp", 1 },
                { "max", 2 },
                { "min", 2 }
            };

            // Use the Compiled option to speed things up
            numberRegEx = new Regex(numberRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            operandRegEx = new Regex(operandRegex, RegexOptions.Compiled);
            mathFunctionsRegEx = new Regex(mathFunctionsRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            whiteSpaceRegEx = new Regex(whiteSpaceRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }

        public static Dictionary<string, int> FunctionArgumentCount { get; private set; }

        public static bool IsOperand(string expression)
        {
            return operandRegEx.Match(expression).Success;
        }

        public static bool IsFunction(string expression)
        {
            return mathFunctionsRegEx.Match(expression).Success;
        }

        public static string RemoveAllWhiteSpaces(string expression)
        {
            return whiteSpaceRegEx.Replace(expression, string.Empty);
        }

        public static Tuple<string, int> GetNextNumber(string expression)
        {
            var match = numberRegEx.Match(expression);

            return match.Success
                ? new Tuple<string, int>(match.Groups[1].Value, match.Groups[1].Index)
                : new Tuple<string, int>(string.Empty, int.MaxValue);
        }

        public static Tuple<string, int> GetNextOperand(string expression)
        {
            var match = operandRegEx.Match(expression);

            return match.Success
                ? new Tuple<string, int>(match.Value.Trim(), match.Index)
                : new Tuple<string, int>(string.Empty, int.MaxValue);
        }

        public static Tuple<string, int> GetNextMathFunction(string expression)
        {
            var match = mathFunctionsRegEx.Match(expression);

            return match.Success
                ? new Tuple<string, int>(match.Groups[1].Value, match.Groups[1].Index)
                : new Tuple<string, int>(string.Empty, int.MaxValue);
        }
    }
}
