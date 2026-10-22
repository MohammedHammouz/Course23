using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Voting_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray committees = new BitArray(8, false);
            committees[3] = true;
            committees[5] = true;
            committees[6] = true;
            var approved=committees.Cast<bool>()
                .Where(bit => bit == true)
                .Select(bit => bit)
               .Count();
            Console.WriteLine(approved);
        }
    }
}
