using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translate_Words_Between_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> translation = new Dictionary<string, string>
            {
                { "Hello", "Hola" },
                {"Goodbye","Adiós" }
            };
            foreach (var word in translation)
            {
                Console.WriteLine($"{word.Key} in Spanish {word.Value}");
            }
        }
    }
}
