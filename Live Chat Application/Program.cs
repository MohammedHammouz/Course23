using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
namespace Live_Chat_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<string> chatMessages = new ObservableCollection<string>();
            chatMessages.CollectionChanged += (sender, e) =>
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {
                    Console.WriteLine($"New Message: {e.NewItems[0]}");
                }
            };
            chatMessages.Add("Hello!");
            chatMessages.Add("How are you?");
            // Output:
            // New Message: Hello!
            // New Message: How are you?
            Console.ReadKey();
        }
    }
}
