using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Collections;


namespace Calculator
{

    public class CalculatorLogic
    {
        // Found numbers in the expression.
        private ArrayList foundNumbers = new ArrayList();

        // Found operators in the expression.
        private ArrayList foundOperators = new ArrayList();

        // List of acceptedoperators.
        private char[] operators = { '+', '-', '/', '%', '*', '÷', '^', '√' };

        // List of special operators, for example exempt from the "Cannot have an operator at the beggining" rule.
        private char[] specialOperators = { '+', '-' };

        // List of accepted numbers
        private char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

        // last operator index, for knowing where to continue from to get numbers in between operators.
        private int lastOpIndex = 0;

        // The original expression, that if it has square roots, will be changed later to have the answers instead, before the normal processing starts.

        public string Expression { get; set; }

        // Constructor to set the Expression value.
        public CalculatorLogic(String expression) => Expression = expression;



        /// <summary>
        /// Parses the expression into two arraylists of operators and numbers. Also checks formatting.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public String Parse()
        {
            if (Expression.Length == 0)
            {
                return "";
            }

            this.formatRoots();

            if ((isOperator(Expression.ElementAt(0)) && !isSpecialOperator(Expression.ElementAt(0))) || isOperator(Expression.ElementAt(Expression.Length - 1)))
            {
                throw new Exception("Cannot have an operator at the beggining or end of expression.");
            }
            else if (Expression.ElementAt(0) == '.' || Expression.ElementAt(Expression.Length - 1) == '.')
            {
                throw new Exception("Cannot have a dot at the beggining or end of expression.");
            }

            for (int i = 0; i < Expression.Length; i++)
            {
                if (i > 0 && isOperator(Expression.ElementAt(i)))
                {
                    if (i < (Expression.Length - 1) && (isOperator(Expression.ElementAt(i + 1)) && Expression.ElementAt(i + 1) != '√'))
                    {
                        throw new Exception("Two operators cannot be next to each other.");
                    }
                    else if ((i > 0 && Expression.ElementAt(i - 1) == '.') ||
                        (i < (Expression.Length - 1) && Expression.ElementAt(i + 1) == '.'))
                    {
                        throw new Exception("Cannot have dot next to operator.");
                    }
                    else
                    {
                        StringBuilder numBuilder = new StringBuilder();
                        if (lastOpIndex == 0)
                        {
                            for (int j = lastOpIndex; j < i; j++)
                            {
                                numBuilder.Append(Expression.ElementAt(j));
                            }
                        }
                        else
                        {
                            for (int j = lastOpIndex + 1; j < i; j++)
                            {
                                numBuilder.Append(Expression.ElementAt(j));
                            }

                        }
                        lastOpIndex = i;
                        if (numBuilder.Length != 0)
                        {
                            foundNumbers.Add(double.Parse(numBuilder.ToString()));
                        }
                    }
                    foundOperators.Add(Expression.ElementAt(i));
                }
                else if (!isOperator(Expression.ElementAt(i))
                && !isNum(Expression.ElementAt(i)) && Expression.ElementAt(i) != '.')
                {
                    throw new Exception("Unknown Symbol");
                }
            }
            StringBuilder numBuilder2 = new StringBuilder();
            if (lastOpIndex == 0)
            {
                for (int j = lastOpIndex; j < Expression.Length; j++)
                {
                    numBuilder2.Append(Expression.ElementAt(j));
                }
            }
            else
            {
                for (int j = lastOpIndex + 1; j < Expression.Length; j++)
                {
                    numBuilder2.Append(Expression.ElementAt(j));
                }
            }
            foundNumbers.Add(double.Parse(numBuilder2.ToString()));

            return calculate();
        }


        /// <summary>
        /// Solves roots separately, creates a new string with the answers to the roots instead of the roots.
        /// </summary>
        public void formatRoots()
        {
            StringBuilder tempStringBuilder = new StringBuilder();
            StringBuilder tempSqrtBuilder = new StringBuilder();
            Double tempSqrt;
            for (int i = 0; i < Expression.Length; i++)
            {
                if (Expression.ElementAt(i) == '√')
                {
                    if (i != 0 && !isOperator(Expression.ElementAt(i - 1)))
                    {
                        tempStringBuilder.Append('*');
                        for (int j = i; j < Expression.Length && (!isOperator(Expression.ElementAt(j)) || i == j); j++)
                        {
                            if (!isOperator(Expression.ElementAt(j)))
                            {
                                tempSqrtBuilder.Append(Expression.ElementAt(j));
                                i++;
                            }
                        }

                        tempSqrt = Math.Sqrt(Double.Parse(tempSqrtBuilder.ToString()));
                        tempStringBuilder.Append(tempSqrt);
                    }
                    else
                    {
                        for (int j = i; j < Expression.Length && (!isOperator(Expression.ElementAt(j)) || j == i); j++)
                        {
                            if (!isOperator(Expression.ElementAt(j)))
                            {
                                tempSqrtBuilder.Append(Expression.ElementAt(j));
                                i++;
                            }
                        }

                        tempSqrt = Math.Sqrt(Double.Parse(tempSqrtBuilder.ToString()));
                        tempStringBuilder.Append(tempSqrt);
                    }
                }
                else
                {
                    tempStringBuilder.Append(Expression.ElementAt(i));


                }
            }
            Expression = tempStringBuilder.ToString();
        }

        /// <summary>
        /// Calculates the answers to each part of the expression, by doing the ith operation on ith and i+1th numbers and
        /// sets the i+1th equal to the answer.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string calculate()
        {
            for (int i = 0; i < foundOperators.Count; i++)
            {
                if ((char)foundOperators[i] == '+')
                {
                    foundNumbers[i + 1] = (double)foundNumbers[i] + (double)foundNumbers[i + 1];
                }
                else if ((char)foundOperators[i] == '-')
                {
                    foundNumbers[i + 1] = (double)foundNumbers[i] - (double)foundNumbers[i + 1];
                }
                else if ((char)foundOperators[i] == '*')
                {
                    foundNumbers[i + 1] = (double)foundNumbers[i] * (double)foundNumbers[i + 1];
                }
                else if ((char)foundOperators[i] == '/' || (char)foundOperators[i] == '÷')
                {
                    if ((double)foundNumbers[i + 1] == 0)
                    {
                        throw new Exception("Cannot divide by zero.");
                    }
                    foundNumbers[i + 1] = (double)foundNumbers[i] / (double)foundNumbers[i + 1];
                }
                else if ((char)foundOperators[i] == '%')
                {
                    foundNumbers[i + 1] = (double)foundNumbers[i] % (double)foundNumbers[i + 1];
                }
                else if ((char)foundOperators[i] == '^')
                {
                    foundNumbers[i + 1] = Math.Pow((double)foundNumbers[i], (double)foundNumbers[i + 1]);
                }
            }
            return foundNumbers[foundNumbers.Count - 1].ToString();

        }

        /// <summary>
        /// Checks if char is an operator just by looping through known operators.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool isOperator(char input)
        {
            bool result = false;
            foreach (char op in operators)
            {
                if (op == input)
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Checks if char is an number just by looping through known numbers.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool isNum(char input)
        {
            bool result = false;
            foreach (char num in numbers)
            {
                if (num == input)
                {
                    result = true;
                }
            }
            return result;
        }


        /// <summary>
        /// Checks if char is an special operator just by looping through known special operators.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool isSpecialOperator(char input)
        {
            bool result = false;
            foreach (char op in specialOperators)
            {
                if (op == input)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}

