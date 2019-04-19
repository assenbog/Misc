namespace RPN.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Parser
    {
        /// <summary>
        /// Implementation of the Shunting-yard algorithm which is a method for parsing mathematical expressions 
        /// specified in infix notation to postfix notation string, also known as Reverse Polish notation
        /// </summary>
        /// <param name="expression">expression to convert from infix notation to postif notation</param>
        /// <returns>expression in Reverse Polish notation</returns>
        public static string ConvertToRPN(string expression)
        {
            var index = 0;
            var separator = new string(' ', 1);
            var functionsAndOperands = new List<TokenTypes> { TokenTypes.Function, TokenTypes.Operand };
            var operatorPrecedence = new Dictionary<string, int> { { "(", 5 }, { "^", 4 }, { "*", 3 }, { "/", 3 }, { "+", 2 }, { "-", 2 } };

            var rpnSb = new StringBuilder();
            var stack = new Stack<string>();

            while (index < expression.Length)
            {
                var token = GetNextToken(expression.Substring(index));

                if (token.Item2 == TokenTypes.None)
                {
                    break;
                }

                if (token.Item2 == TokenTypes.Number)
                {
                    rpnSb.Append($"{token.Item1}{separator}");
                    index += token.Item3 + token.Item1.Length + 1;
                }

                else if (functionsAndOperands.Contains(token.Item2))
                {
                    string stackPeek = stack.Count > 0 ? stack.Peek() : string.Empty;
                    // Check if the top and of the Stack and the current operand are of the same precedence
                    if (operatorPrecedence.ContainsKey(token.Item1) && operatorPrecedence.ContainsKey(stackPeek) &&
                        operatorPrecedence[token.Item1] == operatorPrecedence[stackPeek] && token.Item1 != "^")
                    {
                        rpnSb.Append($"{stack.Pop()}{separator}");
                        stack.Push(token.Item1);
                    }
                    else if (token.Item1 == ")")
                    {
                        while (true)
                        {
                            var stackPop = stack.Pop();
                            if (stackPop == "(")
                            {
                                break;
                            }
                            rpnSb.Append($"{stackPop}{separator}");
                        }
                    }
                    else
                    {
                        stack.Push(token.Item1);
                    }
                    index += token.Item3 + token.Item1.Length + 1;
                }
            }

            while(stack.Count > 0)
            {
                rpnSb.Append($"{stack.Pop()}{separator}");
            }

            return rpnSb.ToString().Trim();
        }

        private static Tuple<string,TokenTypes,int> GetNextToken(string expression)
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
