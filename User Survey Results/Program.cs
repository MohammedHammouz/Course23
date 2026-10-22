using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Survey_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] users = new string[][] { 
                new string[] { "Yes", "No", "Yes", "No", "No" } 
            , new string[] { "Yes", "No", "Yes", "No", "No" }
            ,new string[] { "Yes", "No", "Yes", "No", "No" }
            ,new string[] { "Yes", "No", "Yes", "No", "No" }
            ,new string[] { "Yes", "No", "Yes", "No", "No" }
            ,new string[] { "Yes", "No", "Yes", "No", "No" }
            ,new string[] { "Yes", "No", "Yes", "No", "No" }
            ,new string[] { "Yes", "No", "Yes", "No", "No" }
            ,new string[] { "Yes", "No", "Yes", "No", "No" }
            ,new string[] { "Yes", "No", "Yes", "No", "No" }};
            BitArray Survey = new BitArray(50,false);
            for(int i = 0; i < users.Length; i++)
            {
                Console.Write($"user:{i + 1}:");
                foreach(var survey in users[i])
                {
                    Survey[i] = survey == "Yes";
                    Console.Write(Survey[i]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
