using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Size_Calculation
{
    internal class Program
    {
        class DirectoryNode
        {
            public string Name { get; set; } // Directory or file name
            public int Size { get; set; } // File size (0 for directories)
            public List<DirectoryNode> Children { get; set; } = new List<DirectoryNode>();
            public DirectoryNode(string Name, int Size)
            {
                this.Name = Name;
                this.Size = Size;
            }
            public int CalculateTotalSize()
            {
                int totalSize = Size;
                foreach (var child in Children)
                {
                    totalSize += child.CalculateTotalSize(); // Add sizes of all child nodes
                }
                return totalSize;
            }
            public void Print(string indent = "")
            {
                Console.WriteLine($"{indent}{Name} (Size: {Size})");
                foreach (var child in Children)
                {
                    child.Print(indent + "  ");
                }
            }
        }
        static void Main(string[] args)
        {
            var root = new DirectoryNode("root", 0);
            var documents = new DirectoryNode("Documents", 0);
            var photos = new DirectoryNode("Photos", 0);


            documents.Children.Add(new DirectoryNode("Resume.docx", 50));
            documents.Children.Add(new DirectoryNode("Project.pdf", 100));


            photos.Children.Add(new DirectoryNode("Vacation.jpg", 200));


            root.Children.Add(documents);
            root.Children.Add(photos);


            // Print directory structure
            Console.WriteLine("Directory Structure:");
            root.Print();


            // Calculate and display total size
            Console.WriteLine($"\nTotal size of the directory: {root.CalculateTotalSize()} bytes");


            // Pause the screen
            Console.ReadKey();
        }
    }
}
