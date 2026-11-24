using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pre_order__In_order__Post_order_Traversal_Algorithms
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }
        public BinaryTreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; private set; }
        public BinaryTree()
        {
            Root = null;
        }
        public void Insert(T value)
        {
            var newNode = new BinaryTreeNode<T>(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current.Left == null)
                {
                    current.Left = newNode;
                    break;
                }
                else 
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right == null)
                {
                    current.Right = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Right);
                }
            }
        }
        public void PrintTree()
        {
            PrintTree(Root, 0);
        }
        private void PrintTree(BinaryTreeNode<T>root,int space)
        {
            int COUNT = 10;
            if (root == null)
            {
                return;
            }
            space += COUNT;
            PrintTree(root.Right, space);


            Console.WriteLine();
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(root.Value);
            PrintTree(root.Left, space);
        }
        private void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Value);
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }
        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
            Console.WriteLine();
        }
        private void InOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.WriteLine(node.Value);
                InOrderTraversal(node.Right);
            }
        }
        
        public void InOrderTraversal()
        {
            InOrderTraversal(Root);
            Console.WriteLine();
        }
        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.WriteLine(node.Value);
            }
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();
            Console.WriteLine("Values to be inserted: 5,3,8,1,4,6,9\n");
            binaryTree.Insert(5);
            binaryTree.Insert(3);
            binaryTree.Insert(8);
            binaryTree.Insert(1);
            binaryTree.Insert(4);
            binaryTree.Insert(6);
            binaryTree.Insert(9);
            binaryTree.PrintTree();
            Console.WriteLine("\nPreOrder Traversal (Current-Left SubTree - Right SubTree):");
            binaryTree.PreOrderTraversal();

            Console.ReadKey();

        }
    }
}
