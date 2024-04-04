using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
//ChatGPT code for infix to postfix conversion
class Program
{
    static void Main(string[] args)
    {
        // Define the infix expression
        string infixExpression = "3 + 4 * 5";

        // Convert the infix expression to postfix
        string postfixExpression = ConvertToPostfix(infixExpression);

        // Print the infix and postfix expressions
        Console.WriteLine("Infix Expression: " + infixExpression);
        Console.WriteLine("Postfix Expression: " + postfixExpression);
        
        // Evaluate the postfix expression
        int result = EvaluatePostfix(postfixExpression);
        
        // Print the result
        Console.WriteLine("Result: " + result);
    }

    // Function to convert infix expression to postfix
    static string ConvertToPostfix(string infixExpression)
    {
        string postfix = ""; // Initialize an empty string for the postfix expression
        Stack<char> operatorStack = new Stack<char>(); // Initialize a stack to store operators

        // Loop through each character in the infix expression
        foreach (char token in infixExpression)
        {
            if (char.IsDigit(token)) // If the token is a digit (operand), add it to the postfix expression
            {
                postfix += token;
            }
            else if (IsOperator(token)) // If the token is an operator
            {
                // Pop operators from the stack and append them to the postfix expression 
                // if they have higher or equal precedence than the current token
                while (operatorStack.Count > 0 && Precedence(operatorStack.Peek()) >= Precedence(token))
                {
                    postfix += operatorStack.Pop();
                }
                
                // Push the current operator onto the stack
                operatorStack.Push(token);
            }
        }

        // Pop any remaining operators from the stack and append them to the postfix expression
        while (operatorStack.Count > 0)
        {
            postfix += operatorStack.Pop();
        }

        return postfix; // Return the postfix expression
    }

    // Function to evaluate postfix expression
    // This function assumes that the postfix expression is valid
    static int EvaluatePostfix(string postfixExpression)
    {
        Stack<int> operandStack = new Stack<int>(); // Initialize a stack to store operands

        // Loop through each character in the postfix expression
        foreach (char token in postfixExpression)
        {
            if (char.IsDigit(token)) // If the token is a digit (operand), push it onto the operand stack
            {
                operandStack.Push(token - '0'); // Convert char to int and push onto stack
            }
            else if (IsOperator(token)) // If the token is an operator
            {
                // Pop two operands from the stack and perform the operation
                int operand2 = operandStack.Pop();
                int operand1 = operandStack.Pop();
                int result = PerformOperation(operand1, operand2, token);
                
                // Push the result back onto the operand stack
                operandStack.Push(result);
            }
        }

        return operandStack.Pop(); // Return the final result
    }

    // Function to check if a character is an operator
    static bool IsOperator(char c)
    {
        return c == '+' || c == '-' || c == '*' || c == '/';
    }

    // Function to determine the precedence of an operator
    static int Precedence(char c)
    {
        if (c == '+' || c == '-')
            return 1;
        else if (c == '*' || c == '/')
            return 2;
        else
            return 0;
    }

    // Function to perform arithmetic operation based on operator
    static int PerformOperation(int operand1, int operand2, char op)
    {
        switch (op)
        {
            case '+': return operand1 + operand2;
            case '-': return operand1 - operand2;
            case '*': return operand1 * operand2;
            case '/': return operand1 / operand2;
            default: throw new ArgumentException("Invalid operator");
        }
    }
}

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