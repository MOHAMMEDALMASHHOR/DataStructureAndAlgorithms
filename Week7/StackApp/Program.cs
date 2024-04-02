using System;
using System.Collections.Generic;

// CopilteCode
/* 
namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string infixExpression = "3 + 4 * 2 - 1";
            string postfixExpression = ConvertToPostfix(infixExpression);
            
            Console.WriteLine("Infix Expression: " + infixExpression);
            Console.WriteLine("Postfix Expression: " + postfixExpression);
        }

        static string ConvertToPostfix(string infixExpression)
        {
            string postfixExpression = "";
            Stack<char> stack = new Stack<char>();

            foreach (char c in infixExpression)
            {
                if (char.IsDigit(c))
                {
                    postfixExpression += c;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfixExpression += stack.Pop();
                    }

                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    while (stack.Count > 0 && GetPrecedence(c) <= GetPrecedence(stack.Peek()))
                    {
                        postfixExpression += stack.Pop();
                    }

                    stack.Push(c);
                }
            }

            while (stack.Count > 0)
            {
                postfixExpression += stack.Pop();
            }

            return postfixExpression;
        }

        static int GetPrecedence(char c)
        {
            switch (c)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return -1;
            }
        }
    }
} */