using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Word_Frequencies_in_a_Text
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string s = "hello world hello universe";
            string[] Words = s.Split(' ');
            Dictionary<string, int> WordFrequencies = new Dictionary<string, int>();
            foreach(var word in Words)
            {
                if (!WordFrequencies.ContainsKey(word))
                {
                    WordFrequencies[word] = 1;
                }
                else
                {
                    WordFrequencies[word]++;
                }
            }
            foreach(var wodNo in WordFrequencies)
            {
                Console.WriteLine($"{wodNo.Key}:{wodNo.Value}");
            }
        }
    }
}
