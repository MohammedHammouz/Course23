using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Words_That_Can_Be_Typed_Using_One_Row_of_Keyboard
{
    internal class Program
    {
        static string FindWordsThatCanBeTypedUsingOneRowofKeyboard(string[] words)
        {
            string[] Rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            HashSet<string> Result=new HashSet<string>();
            for(int i = 0; i < words.Length; i++)
            {
                int Row1=0;
                int Row2 = 0; 
                int Row3 = 0;
                foreach(var chr in words[i])
                {
                    if (Rows[0].Contains(char.ToLower(chr)))
                    {
                        Row1++;
                    }
                    if (Rows[1].Contains(char.ToLower(chr)))
                    {
                        Row2++;
                    }
                    if (Rows[2].Contains(char.ToLower(chr)))
                    {
                        Row3++;
                    }
                }
                if(Row1!=0 && Row2==0 &&Row3==0 || Row1 == 0 && Row2 != 0 && Row3 == 0 || Row1 == 0 && Row2 == 0 && Row3 != 0)
                {
                    Result.Add(words[i]);
                }
            }
            return string.Join(",", Result);
        }
        static string[] FindWords(string[] words)
        {
            string[] rows = { "qwertyuiop", "asdfghjkl", "zxcvbnm" };
            Dictionary<char, int> charRow = new Dictionary<char, int>();


            for (int i = 0; i < rows.Length; i++)
            {
                foreach (char c in rows[i])
                {
                    charRow[c] = i;
                }
            }
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                int row = charRow[char.ToLower(word[0])];
                bool isValid = true;
                foreach (char c in word)
                {
                    if (charRow[char.ToLower(c)] != row)
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                    result.Add(word);
            }
            return result.ToArray();
        }

        static void Main(string[] args)
        {
            string[] words = { "Hello", "Alaska", "Dad", "Peace" };
            Stopwatch sw = new Stopwatch();

            
            sw.Start();

            FindWordsThatCanBeTypedUsingOneRowofKeyboard(words);
            Console.WriteLine($"MySolution: {sw.Elapsed.TotalMilliseconds} ms");
            sw.Stop();
            sw.Start();

            FindWords(words);

            sw.Stop();
            Console.WriteLine($"Abu Hadhoud Solution: {sw.Elapsed.TotalMilliseconds} ms");
        }
    }
}
