using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Common_Characters_in_Strings
{
    internal class Program
    {
       
        static List<string> CommonChars(string[] words)
        {
            int[] minFreq = new int[26];
            for(int i = 0; i < 26; i++)
            {
                minFreq[i] = int.MaxValue;
            }
            foreach(var word in words)
            {
                int[] charFreq = new int[26];
                foreach(char c in word)
                {
                    charFreq[c - 'a']++;
                }
                for (int i = 0; i < 26; i++)
                {
                    minFreq[i] = Math.Min(minFreq[i], charFreq[i]);
                }
            }
            List<string> result = new List<string>();
            for(int i = 0; i < 26; i++)
            {
                for (int j = 0; j < minFreq[i]; j++)
                {
                    result.Add(((char)(i + 'a')).ToString());
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder();
            string[] words = { "bella", "label", "roller","lllllllllllllllllll" };

            Console.WriteLine(string.Join(",", CommonChars(words)));
        }
    }
}
