using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Invalid_Parentheses
{
    internal class Program
    {
        static string RemoveInvalidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();
            int count = 0;
            foreach(char c in s)
            {
                if (c == '(')
                {
                    stack.Push(c);
                    count++;
                }
                else if(c==')' && count > 0)
                {
                    stack.Push(c);
                    count--;
                }
            }
            return new string(stack.Reverse().ToArray());
        }
        static void Main(string[] args)
        {
            string s = "(()))";
            Console.WriteLine(string.Join("", RemoveInvalidParentheses(s)));
        }
    }
}
