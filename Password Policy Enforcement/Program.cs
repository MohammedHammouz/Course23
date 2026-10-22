using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Password_Policy_Enforcement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BitArray passwordPolicy= new BitArray(4);
            string password = "Password123!";
            passwordPolicy[0] = password.Any(char.IsDigit);
            passwordPolicy[1] = password.Any(char.IsLower);
            passwordPolicy[2] = password.Any(char.IsUpper);
            passwordPolicy[3] = password.Any(c => "!@#$%^&*".Contains(c));
            bool isValid = passwordPolicy.Cast<bool>().All(bit => bit);
            Console.WriteLine($"Password Valid: {isValid}");
            Console.ReadKey();
        }
    }
}
