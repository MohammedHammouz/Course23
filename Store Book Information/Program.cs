using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Book_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, (string Title, string Author)> BooksInformation = new Dictionary<string, (string, string)>();
            BooksInformation.Add("978-3-16-148410-0", ("The Great Gatsby", "F. Scott Fitzgerald"));
            BooksInformation.Add("978-1-61-729494-5", ("C# in Depth", "Jon Skeet"));
            foreach(var book in BooksInformation)
            {
                Console.WriteLine($"ISBN: {book.Key}, Title: {book.Value.Item1}, Author: {book.Value.Item2}");
            }
        }
    }
}
