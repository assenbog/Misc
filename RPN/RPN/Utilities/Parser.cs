namespace RPN.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Parser
    {
        /// <summary>
        /// Implementation of the Shunting-yard algorithm which is a method for parsing mathematical expressions 
        /// specified in infix notation to postfix notation string, also known as Reverse Polish notation
        /// </summary>
        /// <param name="expression">expression to convert from infix notation to postif notation</param>
        /// <returns>expression in Reverse Polish notation</returns>
        public static Stack<string> ConvertToRPN(string inputExpression)
        {
            var returnValue = new Stack<string>();
            var index = 0;
            var functionsAndOperands = new List<TokenTypes> { TokenTypes.Function, TokenTypes.Operand };
            var operatorPrecedence = new Dictionary<string, int> { { "(", 5 }, { ")", 5 }, { "^", 4 }, { "*", 3 }, { "/", 3 }, { "+", 2 }, { "-", 2 } };
            var brackets = new[] { "(", ")" };

            var rpnSb = new List<string>();
            var stack = new Stack<string>();

            var expression = ExpressionRegex.RemoveAllWhiteSpaces(inputExpression);

            while (index < expression.Length)
            {
                var token = GetNextToken(expression.Substring(index));

                if (token.Item2 == TokenTypes.None)
                {
                    break;
                }

                if (token.Item2 == TokenTypes.Number)
                {
                    rpnSb.Add(token.Item1);
                    index += token.Item3 + token.Item1.Length;
                }

                else if (functionsAndOperands.Contains(token.Item2))
                {
                    string stackPeek = stack.Count > 0 ? stack.Peek() : string.Empty;
                    if (token.Item1 == ")")
                    {
                        while (stack.Any())
                        {
                            var stackPop = stack.Pop();
                            if (stackPop == "(")
                            {
                                break;
                            }
                            rpnSb.Add(stackPop);
                        }
                    }
                    // Check if the top and of the Stack and the current operand are of the same precedence
                    // Note: Same rule applies when we're processing an operand and we have function (not one of the brackets!) on top of the stack
                    else if (operatorPrecedence.ContainsKey(token.Item1) && operatorPrecedence.ContainsKey(stackPeek) &&
                        operatorPrecedence[token.Item1] == operatorPrecedence[stackPeek] && token.Item1 != "^" ||
                        token.Item2 == TokenTypes.Operand && !brackets.Contains(token.Item1) && ExpressionRegex.IsFunction(stackPeek))
                    {
                        rpnSb.Add(stack.Pop());
                        stack.Push(token.Item1);
                    }
                    else
                    {
                        stack.Push(token.Item1);
                    }
                    index += token.Item3 + token.Item1.Length;
                }
            }

            while (stack.Count > 0)
            {
                rpnSb.Add(stack.Pop());
            }

            rpnSb.Reverse();

            rpnSb.ForEach(p => returnValue.Push(p));

            return returnValue;
        }

        private static Tuple<string, TokenTypes, int> GetNextToken(string expression)
        {
            // Try to get a number first
            var number = ExpressionRegex.GetNextNumber(expression);

            // Try function next
            var function = ExpressionRegex.GetNextMathFunction(expression);

            // Operand last
            var operand = ExpressionRegex.GetNextOperand(expression);

            // Find the min index. This will indicate what the next token is
            var minIndex = Math.Min(Math.Min(number.Item2, function.Item2), operand.Item2);

            if (minIndex == number.Item2)
            {
                return new Tuple<string, TokenTypes, int>(number.Item1, TokenTypes.Number, number.Item2);
            }

            if (minIndex == function.Item2)
            {
                return new Tuple<string, TokenTypes, int>(function.Item1, TokenTypes.Function, function.Item2);
            }

            if (minIndex == operand.Item2)
            {
                return new Tuple<string, TokenTypes, int>(operand.Item1, TokenTypes.Operand, operand.Item2);
            }

            return new Tuple<string, TokenTypes, int>(string.Empty, TokenTypes.None, int.MinValue);
        }
    }
}
