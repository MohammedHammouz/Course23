using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_palindrome_using_a_stack
{
    internal class Program
    {
        static bool IsPalindrome(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in input)
            {
                stack.Push(c);
            }
            foreach(char c in input)
            {
                if (c != stack.Pop())
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            string input = "madam";
            Console.WriteLine(IsPalindrome(input));
            input = "hello";
            Console.WriteLine(IsPalindrome(input));
        }
    }
}
