namespace RPN.Utilities
{
    using System;
    using System.Collections.Generic;

    public static class Calculator
    {
        public static double Calculate(string expression)
        {
            var calcStack = new Stack<string>();

            var rpnNotation = Parser.ConvertToRPN(expression);

            while (rpnNotation.Count > 0)
            {
                var rpnToken = rpnNotation.Pop();

                if(ExpressionRegex.IsFunction(rpnToken))
                {
                    var argumentCount = ExpressionRegex.FunctionArgumentCount[rpnToken];
                    if(calcStack.Count >= argumentCount)
                    {
                        var argList = new List<double>();

                        for(var i = 0; i < argumentCount; i++)
                        {
                            argList.Add(double.Parse(calcStack.Pop()));
                        }

                        var calculateFunctionResult = CalculateFunction(rpnToken, argList.ToArray()).ToString();

                        calcStack.Push(calculateFunctionResult);
                    }
                    else
                    {
                        throw new ArgumentException($"Unable to find {argumentCount} arguments for {rpnToken}");
                    }
                }
                else if (ExpressionRegex.IsOperand(rpnToken))
                {
                    if(calcStack.Count < 2)
                    {
                        throw new ArgumentException($"Unable to find 2 arguments for {rpnToken}");
                    }
                    else
                    {
                        var arg1 = double.Parse(calcStack.Pop());
                        var arg2 = double.Parse(calcStack.Pop());

                        var calculateOperandResult = CalculateOperand(rpnToken, arg2, arg1).ToString();

                        calcStack.Push(calculateOperandResult);
                    }
                }
                else // Number TokenType
                {
                    calcStack.Push(rpnToken);
                }
            }

            // There should be only 1 item left on the stack at this stage
            return double.Parse(calcStack.Pop());
        }

        private static double CalculateOperand(string operand, double arg1, double arg2)
        {
            switch(operand)
            {
                case "^":
                    return Math.Pow(arg1, arg2);
                case "*":
                    return arg1 * arg2;
                case "/":
                    return arg1 / arg2;
                case "+":
                    return arg1 + arg2;
                case "-":
                    return arg1 - arg2;
                default:
                    throw new ArgumentException($"Unknown operand {operand}");
            }
        }

        private static double CalculateFunction(string functionName, params double [] functionArgument)
        {
            switch(functionName)
            {
                case "abs":
                    return Math.Abs(functionArgument[0]);
                case "cos":
                    return Math.Cos(functionArgument[0] * Math.PI / 180D);
                case "sin":
                    return Math.Sin(functionArgument[0] * Math.PI / 180D);
                case "tan":
                    return Math.Tan(functionArgument[0] * Math.PI / 180D);
                case "log":
                    return Math.Log(functionArgument[0]);
                case "acos":
                    return Math.Acos(functionArgument[0]) * 180D / Math.PI;
                case "asin":
                    return Math.Asin(functionArgument[0]) * 180D / Math.PI;
                case "atan":
                    return Math.Atan(functionArgument[0]) * 180D / Math.PI;
                case "sqrt":
                    return Math.Sqrt(functionArgument[0]);
                case "exp":
                    return Math.Exp(functionArgument[0]);
                case "max":
                    return Math.Max(functionArgument[0], functionArgument[1]);
                case "min":
                    return Math.Min(functionArgument[0], functionArgument[1]);
                default:
                    throw new ArgumentException($"Unknown function name {functionName}");
        }
        }
    }
}
