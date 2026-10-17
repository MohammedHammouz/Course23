using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Calculator
{
    internal class Program
    {
        static int Calculator(string Equation)
        {
            int result = 0, sign = 1, number = 0;
            Stack<int> stack = new Stack<int>();
            foreach (char c in Equation)
            {
                if (char.IsDigit(c))
                {
                    number = number * 10 + (c - '0');
                }
                else if (c == '+')
                {
                    result += sign * number;
                    number = 0;
                    sign = 1;
                }
                else if (c == '-')
                {
                    result += sign * number;
                    number = 0;
                    sign = -1;
                }
                else if (c == '(')
                {
                    stack.Push(result);
                    stack.Push(sign);
                    result = 0;
                    sign = 1;
                }
                else if (c == ')')
                {
                    result += number * sign;
                    number = 0;
                    result *= stack.Pop();
                    result += stack.Pop();
                }
            }
            return result+sign*number;
        }
        static void Main(string[] args)
        {
            string Equation = "1 + (2 - 9)";
            Console.WriteLine(Calculator(Equation));
        }
    }
}
