using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Number_of_True_Bits_Or_False_Bits_in_a_BitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray array = new BitArray(new bool[] { true, false, true, true, false, false, true, true });
            int NumberOfFalseBits = array.Cast<bool>()
                .Where(bit => bit == false)
                .Select(bit => bit)
                .Count();
            int NumberOfTrueBits = array.Cast<bool>()
                .Where(bit => bit == true)
                .Select(bit => bit)
                .Count();
            Console.WriteLine($"Number Of False bits:{NumberOfFalseBits}");
            Console.WriteLine($"Number Of True bits:{NumberOfTrueBits}");
        }
    }
}
