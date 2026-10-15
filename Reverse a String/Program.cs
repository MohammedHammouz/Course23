using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_String
{
    internal class Program
    {
        static Stack<char> ReverseAString(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in s)
            {
                stack.Push(c);
            }
            return stack;
        }
        static void Main(string[] args)
        {

            string s = "Hello";
            Stack<char> stack = ReverseAString(s);
            Console.WriteLine(string.Join("", stack));
        }
    }
}
