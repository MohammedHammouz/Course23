using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluate_a_Postfix_Expression
{
    internal class Program
    {
        static int EvaluatePostfix(string s)
        {
            Stack<int> stackOfnumbers = new Stack<int>();
            foreach(char c in s)
            {
                if (c == '*' || c == '+' || c == '-')
                {
                    int num1 = stackOfnumbers.Pop();
                    int num2 = stackOfnumbers.Pop();
                    if (c == '+')
                    {
                        stackOfnumbers.Push(num2+ num1);
                    }
                    else if (c == '*')
                    {
                        stackOfnumbers.Push(num2 * num1);
                    }
                    else if (c == '-')
                    {
                        stackOfnumbers.Push(num2 - num1);
                    }
                }
                else if (c!='*' || c!='+' || c!='-')
                {
                    stackOfnumbers.Push(c - '0');
                }  
               
            }
            return stackOfnumbers.Pop();
        }
        static void Main(string[] args)
        {
            string s = "231*+9-";
            Console.WriteLine(EvaluatePostfix(s));
        }
    }
}
