using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Category_Hierarchy
{
    class CategoryNode
    {
        public string Name { get; set; }
        public List<CategoryNode> SubCategories { get; set; } = new List<CategoryNode>();
        public CategoryNode(string name)
        {
            Name = name;
        }
        public void Print(string indent="  ")
        {
            Console.WriteLine(indent + Name);
            foreach (var subCategory in SubCategories) // Loop through subcategories
            {
                subCategory.Print(indent + "  "); // Recursively print subcategories with indentation
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = new CategoryNode("Electronics"); // Root category
            var mobiles = new CategoryNode("Mobiles"); // Subcategory for mobiles
            var laptops = new CategoryNode("Laptops"); // Subcategory for laptops
            var samsung = new CategoryNode("Samsung"); // Sub-subcategory for Samsung
            var apple = new CategoryNode("Apple"); // Sub-subcategory for Apple
            mobiles.SubCategories.Add(samsung);
            mobiles.SubCategories.Add(apple);
            root.SubCategories.Add(mobiles);
            root.SubCategories.Add(laptops);
            Console.WriteLine("Category Hierarchy:");
            root.Print(); // Start from the root

            // Pause the screen
            Console.ReadKey();
        }
    }
}
