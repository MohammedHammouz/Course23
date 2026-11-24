using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Representing_a_Social_Network
{
    class Person
    {
        public string Name { get; set; } 
        public List<Person> Friends { get; set; } = new List<Person>();
        public Person(string name)
        {
            Name = name;
        }
        public void Print(int Depth,string Indent="    ")
        {
            if (Depth == 0) return;
            Console.WriteLine(Indent + Name);
            foreach(var friend in Friends)
            {
                friend.Print(Depth - 1, Indent + "  ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var alice = new Person("Alice");
            var bob = new Person("Bob");
            var charlie = new Person("Charlie");
            alice.Friends.Add(bob);
            alice.Friends.Add(charlie);
            var dave = new Person("Dave");
            bob.Friends.Add(dave);
            // Print Alice's social network up to 2 levels deep
            Console.WriteLine("Alice's Social Network:");
            alice.Print(2);
            Console.ReadKey();
        }
    }
}
