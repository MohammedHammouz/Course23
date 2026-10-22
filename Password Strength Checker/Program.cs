using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Strength_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "Hello123!";
            BitArray checks = new BitArray(4, false);
            foreach(char c in password)
            {
                if (char.IsUpper(c)) checks[0] = true;
                if (char.IsLower(c)) checks[1] = true;
                if (char.IsDigit(c)) checks[2] = true;
                if (!char.IsLetterOrDigit(c)) checks[3] = true;
            }
            Console.WriteLine($"Password Strength: {checks[0]}, {checks[1]}, {checks[2]}, {checks[3]}");
            // Output: Password Strength: True, True, True, True
            Console.ReadKey();
        }
    }
}
