using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
namespace Shopping_Cart_for_an_E_commerce_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> cart = new ObservableCollection<string>();
            cart.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                    Console.WriteLine($"Item Added to Cart: {e.NewItems[0]}");
                if (e.Action == NotifyCollectionChangedAction.Remove)
                    Console.WriteLine($"Item Removed from Cart: {e.OldItems[0]}");
            };
            cart.Add("Laptop");
            cart.Add("Mouse");
            cart.Remove("Mouse");
            Console.ReadKey();
        }
    }
}
