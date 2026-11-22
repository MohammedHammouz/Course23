using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_System_Organization
{
    //public class TreeNode<T>
    //{
    //    public T Value { get; set; }
    //    public List<TreeNode<T>> Children { get; set; }
    //    public string Word { get; }
    //    public TreeNode(T Value,string word="")
    //    {
    //        this.Value = Value;
    //        this.Children = new List<TreeNode<T>>();
    //        this.Word = word;
    //    }
    //    public  void AddChild(TreeNode<T> node)
    //    {
    //        this.Children.Add(node);
    //    }
    //    public void Print(TreeNode<string>node,string Ident="")
    //    {
    //        Console.WriteLine($"{Ident}-{node.Word}:{node.Value}");
    //        foreach(var child in node.Children)
    //        {
    //           Print(child,Ident+"    ");
    //        }
    //    }
    //}
    //public class Tree<T>
    //{
    //    public TreeNode<T> Root { get;private set; }
    //    public Tree(T rootvalue)
    //    {
    //        this.Root = new TreeNode<T>(rootvalue);
    //    }
    //}
    class FileNode
    {
        public string Name { get; set; }
        public bool IsFile { get; set; }
        public List<FileNode> Children { get; set; } = new List<FileNode>();
        public enum enType
        {
            Directory,
            File
        }
        public FileNode(string name,enType fType)
        {
            Name = name;
            IsFile = fType == enType.File ? true : false;
        }
        public void Print(string indent="  ")
        {
            Console.WriteLine(indent + (IsFile ? "File: " : "Directory: ") + Name);
            foreach(var child in Children)
            {
                child.Print(indent + "  ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tree<string> Files = new Tree<string>("root");
            //TreeNode<string> SubFiles=new TreeNode<string>(Files.Root.Value,"Directory");
            //TreeNode<string> documents = new TreeNode<string>("Documents", "Directory");
            //TreeNode<string> photos = new TreeNode<string>("Photos", "Directory");
            //SubFiles.AddChild(documents);
            //SubFiles.AddChild(photos);
            //SubFiles.Print(Files.Root);
            //documents.AddChild(new TreeNode<string>("Resume.docx","File"));
            //documents.AddChild(new TreeNode<string>("Project.pdf", "File"));
            //SubFiles.Print(documents,"    ");
            //photos.AddChild(new TreeNode<string>("Vacation.jpg", "File"));
            //photos.AddChild(new TreeNode<string>("Diving.jpg", "File"));
            //photos.AddChild(new TreeNode<string>("Family.jpg", "File"));
            //SubFiles.Print(photos,"     ");
            var root = new FileNode("root", FileNode.enType.Directory);
            var documents = new FileNode("documents", FileNode.enType.File);
            var photos = new FileNode("Photos", FileNode.enType.Directory);
            documents.Children.Add(new FileNode("Resume.docx", FileNode.enType.File));
            documents.Children.Add(new FileNode("Project.pdf", FileNode.enType.File));
            photos.Children.Add(new FileNode("Vacation.jpg", FileNode.enType.File));
            photos.Children.Add(new FileNode("Diving.jpg", FileNode.enType.File));
            photos.Children.Add(new FileNode("Family.jpg", FileNode.enType.File));
            root.Children.Add(documents);
            root.Children.Add(photos);
            Console.WriteLine("File System:\n");
            root.Print();


            // Pause the screen
            Console.ReadKey();

        }
    }
}
