using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>
            {
                {"Alice","123-456-7890"},
                {"Bob","987-654-3210" }
            };
            foreach(var phone in PhoneBook)
            {
                Console.WriteLine($"{phone.Key}'s : {phone.Value}");
            }
        }
    }
}
