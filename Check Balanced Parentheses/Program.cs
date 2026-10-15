using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Balanced_Parentheses
{
    internal class Program
    {
        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();
            foreach(char c in input)
            {
                if(c=='('|| c=='[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                        return false;
                    char top = stack.Pop();
                    if((c==')' && top!='(')||(c==']' && c!='[') || (c == '}' && c != '{'))
                    {
                        return false;
                    }
                }
            }
            return stack.Count == 0;
        }
        static void Main(string[] args)
        {
            string input = "({[]})";
            Console.WriteLine($"Is \"{input}\" balanced? {IsBalanced(input)}");


            input = "({[)]}";
            Console.WriteLine($"Is \"{input}\" balanced? {IsBalanced(input)}");


            Console.ReadKey();

        }
    }
}
