using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Employee_Management
{
    internal class Program
    {
        public class EmployeeNode
        {
            public string Name { get; set; }
            public string Position { get; set; }
            public List<EmployeeNode> Subordinates { get; set; } = new List<EmployeeNode>();
            public EmployeeNode(string name,string position)
            {
                Name = name;
                Position = position;
                
            }
            public void Print(string indent = "  ")
            {
                Console.WriteLine(indent + Name + ":" + Position);
                foreach(var child in Subordinates)
                {
                    child.Print(indent + "  ");
                }
            }
        }
        static void Main(string[] args)
        {
            var ceo = new EmployeeNode("Alice", "CEO");
            var vp = new EmployeeNode("Bob", "VP of Marketing");
            var manager = new EmployeeNode("Charlie", "Marketing Manager");
            vp.Subordinates.Add(manager);
            ceo.Subordinates.Add(vp);
            vp = new EmployeeNode("Lara", "VP of Technology");
            manager = new EmployeeNode("Tom", "Architect");
            vp.Subordinates.Add(manager);
            ceo.Subordinates.Add(vp);
            ceo.Print();
            Console.ReadKey();
        }
    }
}
