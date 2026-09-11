using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNon_RepeatingCharacterInStream
{
    
    internal class Program
    {
        static void FindFirstRepeatingLetter(string stream)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            Queue<char> queue = new Queue<char>();
            foreach (char item in stream)
            {
                if (!dict.ContainsKey(item))
                    dict[item] = 0;
                dict[item]++;
                queue.Enqueue(item);
                while(queue.Count>0 && dict[queue.Peek()] > 1)
                {
                    queue.Dequeue();
                }
                
                Console.Write(queue.Count > 0 ? queue.Peek(): '-');
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }
           
            
            
        }
        static void Main(string[] args)
        {
            FindFirstRepeatingLetter("aabbbbbbc");
        }
    }
}
