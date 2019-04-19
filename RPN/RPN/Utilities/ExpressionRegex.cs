namespace RPN.Utilities
{
    using System;
    using System.Text.RegularExpressions;

    public static class ExpressionRegex
    {
        private static readonly Regex numberRegEx;
        private static readonly Regex operandRegEx;
        private static readonly Regex mathFunctionsRegEx;

        static ExpressionRegex()
        {
            const string numberRegex = @"^.*?(\d*\.\d+E{1}[-+]?\d{1,3}|\d*\.\d+|\d+).*?$";
            // Note: () are special types of operands
            const string operandRegex = @"\s*?\^|\*|\/|\+|\-|\)|\(";
            const string mathFunctionsRegex = @"^.*?(abs|sin|cos|tan|log|alog|asin|acos|atan|sqrt|exp).*?$";

            // Use the Compiled option to speed things up
            numberRegEx = new Regex(numberRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            operandRegEx = new Regex(operandRegex, RegexOptions.Compiled);
            mathFunctionsRegEx = new Regex(mathFunctionsRegex, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }

        public static Tuple<string, int> GetNextNumber(string expression)
        {
            var match = numberRegEx.Match(expression);

            return match.Success 
                ? new Tuple<string,int>(match.Groups[1].Value, match.Groups[1].Index) 
                : new Tuple<string,int>(string.Empty,int.MaxValue);
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
